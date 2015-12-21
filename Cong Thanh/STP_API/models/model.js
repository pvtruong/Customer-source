var underscore = require("underscore")
var async = require("async")
var sql = require("../libs/sqlserver")
module.exports.create = function(schema,options){
	return function(data){
		if(!options) options ={}
		if(!options.onSave) options.onSave = function(data,cb){cb()};
		var self = this;
		this.schema = schema;
		this.options = options;
		this.data =[]
		if(underscore.isArray(data)){
			this.data = data
		}else{
			if(underscore.isObject){
				this.data.push(data)
			}
		}
		//valid
		self.details =[]
		this.valid = function(callback){
			self.details =[]
			async.map(self.data,function(d,callback){
				for(var key in self.schema.fields){
					var field = self.schema.fields[key];
					//set defult and check required
					if(d[key]==undefined || d[key]==null){
						if(field.default!=undefined && field.default!=null){
							d[key] = field.default;
						}else{
							if(field.required){
								return callback("Trường '" + key + "' yêu cầu phải có dữ liệu")
							}
						}
					}
					//check MAX length
					if(field.maxLength && field.type=="String" && d[key] && d[key].toString().length > field.maxLength){
						return callback("Độ dài tối đa của trường '" + key + "' là " + field.maxLength +", giá trị hiện tại là '" + d[key] + "'(" + d[key].toString().length + " ký tự)");
					}
				}
				//details
				if(self.options.modelDetails){
					var modelkeys = underscore.keys(self.options.modelDetails)
					async.map(modelkeys,function(modelkey,callback){
						var detail_data = d[modelkey];
						if(detail_data){
							//create detail model
							var detailModel = self.options.modelDetails[modelkey];
							var detail = new detailModel(detail_data);
							var fields = underscore.keys(detail.schema.fields);
							self.details.push(detail);
							//sync master and detail
							detail.data.forEach(function(row){
								fields.forEach(function(field){
									if(row[field] == undefined || row[field]==null){
										if(d[field]!==undefined && d[field]!==null){
											row[field] =d[field]; 
										}
									}
								})
							})
							//valid
							detail.valid(function(e){
								if(e) return callback(e)
								callback()
							})
							
						}else{
							callback()
						}
						
					},function(e,rs){
						if(e) return callback(e)
						callback()
					})
					
				}else{
					callback(null,d);
				}
				
			},function(e,rs){
				if(e) return callback(e);
				callback();
				
			})
		}
		//save
		this.save = function(callback){
			if(self.data.length==0) return callback(null)
			self.options.onSave(self.data,function(e){
				if(e) return callback(e)
				//check valid
				self.valid(function(e){
					if(e) return callback(e);
					//create template query
					var template="insert into " + self.schema.name + "(" + underscore.keys(self.schema.fields).join(",") + ") values("
					var cols
					for(var key in self.schema.fields){
						if(!cols){
							cols = "{{" + key +  "}}"
						}else{
							cols = cols + ",{{" + key +  "}}"
						}
					}
					template = template + cols + ")";
					//save to database
					async.map(self.data,function(d,callback){
						var t = template;
						for(var key in self.schema.fields){
							var field = self.schema.fields[key]
							var value = d[key]
							switch(field.type.toLowerCase()){
								case "number":
									if(value==undefined || value==null)
										value =0;
									else{
										try{
											value = Number(value);
										}catch(e){
											return callback("Không thể chuyển giá trị '" + value + "' sang dạng số cho trường '" + key + "'");
										}
									}
									if(!underscore.isNumber(value)){
										return callback("Không thể chuyển giá trị '" + value + "' sang dạng số cho trường '" + key + "'");
									}
									t = t.replace("{{" + key + "}}",value)
									break;
								case "boolean":
									if(value)
										value =1;
									else
										value =0;
									t = t.replace("{{" + key + "}}",value)
									break;
								case "date":
									if(!value)
										value="null"
									else{
										if(!underscore.isDate(value)){
											return callback("Không thể chuyển giá trị '" + value + "' sang dạng ngày cho trường '" + key + "'");
										} 
										value = "'" + value.getFullYear() + "-" + (value.getMonth()+1) + "-" + value.getDate() + "'";
									}
									t = t.replace("{{" + key + "}}",value)
									break;
								case "datetime":
									if(!value)
										value="null"
									else{
										try{
											value = new Date(value)
										}catch(e){
											
										}
										
										if(!underscore.isDate(value)){
											return callback("Không thể chuyển giá trị '" + value + "' sang dạng ngày cho trường '" + key + "'");
										} 
										value = "'" + value.getFullYear() + "-" + (value.getMonth()+1) + "-" + value.getDate() + " " + value.getHours() + ":" + value.getMinutes() + ":" + value.getSeconds() + "'";
									}
									t = t.replace("{{" + key + "}}",value)
									break;
								case 'string':
									if(!value) value=""
									t = t.replace("{{" + key + "}}","N'" + value + "'")
									break;
								default:
									t = t.replace("{{" + key + "}}","null")
									break;
							}
						}
						callback(null,t)
					},function(e,rs){
						if(e){
							return callback(e)
						}
						var query = rs.join("\n");
						sql.execute(query,function(e,rs){
							if(e) return callback(e)
							self.data.forEach(function(obj){
								var q = "exec notnull '" + self.schema.name + "', 'stt_rec=''" + obj.stt_rec + "'''"
								sql.execute(q,function(e,rs){
									if(e) console.log(q)
								})
							})
							
							async.map(self.details,function(detail,callback){
								detail.save(function(e,rs){
									if(e) return callback(e);
									callback(null,rs)
								})
							},function(e,rs){
								if(e) return callback(e)
								callback(null,self.data)
							})
							
							
						})
					})
				})
			})
			
			
			
		}
	}
}