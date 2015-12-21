var underscore = require("underscore")
var sql = require("../libs/sqlserver");
var Schema =  function(schema,name){
	this.name = name;
	var self =this;
	this.fields ={
	}
	if(schema){
		underscore.extend(this.fields,schema);
	}
	this.create = function(callback){
		var query ="exec getschema '" + name + "'"
		sql.query(query,function(e,rs){
			if(e){
				console.log("Can't create schema from table name\n",query)
				return callback(e)
				
			} 
			rs.forEach(function(r){
				if(underscore.contains(["numeric","decimal",'real','int','smallint','tinyint','float'],r.type)){
					r.type ="Number"
				}
				if(underscore.contains(['nvarchar','varchar','nchar','char','text','ntext'],r.type)){
					r.type ="String"
				}
				if(underscore.contains(['smalldatetime'],r.type)){
					r.type ="Datetime"
				}
				if(r.type=='bit') r.type='Boolean'
				if(!self.fields[r.name]){
					self.fields[r.name] = r
				}else{
					self.fields[r.name].maxLength = r.maxLength;
					self.fields[r.name].required = r.required;
				}
			})
			callback(null,self.fields)
		})
	}
}
module.exports = Schema;