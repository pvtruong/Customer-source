var fs = require("fs");
var express = require("express");
var underscore = require("underscore");
var passport = require("passport");
var path = require("path")
var multer  = require('multer')
var async = require("async");
module.exports = function(app){
	//authentications
	var auth_local = require("./auths/local");
	auth_local(app,passport);
	
	var bearer = require("./auths/bearer");
	bearer(passport);
	//main router
	var router = express.Router();
	router.use(function(req,res,next){
		for(var key in req.query){
			if(req.query[key]=='true'){
				req.query[key] = true;
			}
			if(req.query[key]=='false'){
				req.query[key] = false;
			}
		}
		var access_token = req.query.access_token || req.query.token;
		if(!access_token){
			access_token= req.get("X-Access-Token");
		}
		if(access_token){
			req.query.access_token = access_token;
		}
		next();
	});
	router.use(passport.authenticate('bearer', { session: false }));
	router.use(multer({ dest: './uploads'}))
	
	app.use("/api",router);
	//vouchers
	fs.readdirSync("./modules/vouchers").forEach(function(file){
		if(file.substr(-3)==".js"){
			voucher = require("./modules/vouchers/" + file);
			voucher(router);
		}
	});
	//reports
	fs.readdirSync("./modules/reports").forEach(function(file){
		if(file.substr(-3)==".js"){
			report = require("./modules/reports/" + file);
			report(router);
		}
	});
	//lists
	fs.readdirSync("./modules/lists").forEach(function(file){
		if(file.substr(-3)==".js"){
			list = require("./modules/lists/" + file);
			list(router);
		}
	});
	//sys router 
	var sys_router = express.Router();
	sys_router.use(multer({ dest: './uploads'}))
	sys_router.use(passport.authenticate('bearer', { session: false }));
	app.use("/api",sys_router);
	//
	fs.readdirSync("./modules/systems").forEach(function(file){
		if(file.substr(-3)==".js"){
			sys = require("./modules/systems/" + file);
			sys(sys_router);
		}
	});
	//public
	var public_router = express.Router();
	public_router.use(function(req,res,next){
		for(var key in req.query){
			if(req.query[key]=='true'){
				req.query[key] = true;
			}
			if(req.query[key]=='false'){
				req.query[key] = false;
			}
			
			
		}
		next();
	});
	public_router.use(multer({ dest: './uploads'}))
	app.use("/public",public_router);
	fs.readdirSync("./modules/public").forEach(function(file){
		if(file.substr(-3)==".js"){
			p = require("./modules/public/" + file);
			p(public_router);
		}
	});
	
}