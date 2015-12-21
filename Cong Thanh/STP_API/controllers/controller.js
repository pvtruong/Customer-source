
var EventEmitter = require("events").EventEmitter;
var underscore = require("underscore");
var async = require("async");
var sql = require("../libs/sqlserver")
var post = require("../libs/post")
var fs = require("fs");
var userAdmins = require("../configs").admins;
var moment = require("moment")
var bodyToJson = function(body){
	if(body.json){
		body = eval("(" + body.json + ")");
	}			
	return body;
}
var controller = function(router,model,name,options){
	this.name = name;
	this.model = model;
	this.router = router;
	this.module = this.name;
	if(!options){
		options ={};
	}
	this.route_name = "/" + this.name;
	this.options = options;
}
controller.prototype.__proto__ = EventEmitter.prototype;
controller.prototype.create =function(){
	var ctrl = this;
	var model = ctrl.model;
	this.router.route(this.route_name).post(
		function(req,res,next){
			var body = req.body;
			if(!body) return res.send(411,"Không có nội dung cần lưu");
			body = bodyToJson(body);
			sql.findOne("exec createsttrec '" + ctrl.name.toUpperCase() + "'",function(e,stt_rec){
				if(e || !stt_rec) return res.status(400).send("Không thể tạo được bản ghi mới");
				body.stt_rec = stt_rec.stt_rec
				body.nguoi_tao = req.user.id
				var master = new model(body);
				req.master = master;
				next()
			})
		},
		function(req,res,next){
			var master = req.master;
			master.save(function(e,objs){
				if(e) return res.status(400).send(e);
				objs.forEach(function(obj){
					post(obj,function(e,rs){
						if(e) console.log(e)
					})
				})
				res.send(objs)
				
			})
		}
	);
}

controller.prototype.route = function(setRoute){
	this.create();
	if(setRoute){
		setRoute(this.router);
	}
}
module.exports = controller;