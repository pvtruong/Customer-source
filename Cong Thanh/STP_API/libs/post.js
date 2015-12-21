var sql = require("./sqlserver")
var Model = require("../models/model")
var Schema = require("../models/Schema")
var async = require("async")
var underscore = require("underscore")
var post = function(obj,callback){
	//get store
	var sql_stores = "select * from voucherstore where voucherid='" + obj.ma_ct + "' order by stt"
	sql.query(sql_stores,function(e,stores){
		if(e) return callback(e);
		async.mapSeries(stores,function(store,callback){
			var storeName = store.storeName.toLowerCase();
			var tableName = store.tableName;
			var delete_condition = store.delete_condition.toLowerCase();
			var status_run = store.status_run;
			var delete_yn = store.delete_yn;
			var query_store;
			var query_delete;
			if(delete_yn){
				query_delete = "delete from " + tableName + " where " + delete_condition;
			}
			if(status_run<=obj.status){
				query_store ="exec " + storeName;
			}
			
			for(var key in obj){
				var v = obj[key];
				if(underscore.isDate(v)) v = "'" + v.getFullYear() + "-" + (v.getMonth()+1) + "-" + v.getDate()
				if(underscore.isBoolean(v)){
					if(v==false) v =0; else v=1;
				}
				if(underscore.isString(v)) v ="N'" + v + "'"
				if(v==undefined || v==null) v ="''" 
				if(query_delete){
					query_delete = query_delete.split("#" + key.toLowerCase() + "#").join(v)
				}
				if(query_store){
					query_store = query_store.split("#" + key.toLowerCase() + "#").join(v)
				}
			}
			async.waterfall([
				//delete
				function(callback){
					if(query_delete){
						sql.execute(query_delete,function(e,rs){
							if(e) return callback(e)
							callback()
						})
					}else{
						callback()
					}
				},
				//post
				function(callback){
					if(query_store){
						sql.query(query_store,function(e,data){
							if(e) return callback(e)
							var schema = new Schema(null,tableName);
							schema.create(function(e,rs){
								if(e) return callback(e)
								
								var Md = Model.create(schema);
								var md = new Md(data);
								md.save(function(e,data){
									if(e) callback(e)
									callback(null,data)
								})
								
							})
							
						})
					}else{
						callback()
					}
				}
			],function(e,rs){
				if(e) return callback(e)
				callback(null,rs)
			})
			
		},function(e,rs){
			if(e) return callback(e)
			callback(null,rs)
		})
	})
}
module.exports = post;