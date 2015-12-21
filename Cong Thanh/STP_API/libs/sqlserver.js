var sql = require('mssql'); 
var underscore = require("underscore");
var sqlconfig = require('../configs').sqlconfig;
exports.request = function(callback){
	var config = {};
	underscore.extend(config,sqlconfig);
	var connection = new sql.Connection(config, function(err) {
		if(err) return callback(err);
		var request = new sql.Request(connection);
		callback(null,request,connection);
	})
}
exports.query = function(query,callback){
	exports.request(function(err,req,connection){
		if(err) return callback(err);
		req.query(query, function(err, recordset) {
			connection.close();
			if(err) {
				return callback(err);
			}
			return callback(null,recordset);
		});
	})
}
exports.execute = function(query,callback){
	exports.query(query,callback)
}
exports.findOne = function(query,callback){
	exports.query(query,function(e,rs){
		if(e) return callback(e);
		if(rs && rs.length>0){
			callback(null,rs[0])
		}else{
			callback()
		}
	})
}