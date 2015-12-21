
var express = require("express");
var bodyParser = require('body-parser');
var passport = require("passport");
var underscore = require('underscore');
//database
var configs = require("./configs");
global.port = process.env.PORT || configs.PORT;
//app
var app = express();
app.options('/*', function(req, res){
    res.header('Access-Control-Allow-Origin', req.headers.origin || "*");
    res.header('Access-Control-Allow-Methods', 'GET,POST,PUT,HEAD,DELETE,OPTIONS');
    res.header('Access-Control-Allow-Headers', 'content-Type,x-requested-with,X-Access-Token,Authorization');
    res.send(200);
});
app.use(function(req,res,next){
	//allow cross domain
	res.header('Access-Control-Allow-Origin', req.headers.origin || "*");
    res.header('Access-Control-Allow-Methods', 'GET,POST,PUT,HEAD,DELETE,OPTIONS');
    res.header('Access-Control-Allow-Headers', 'content-Type,x-requested-with,X-Access-Token,Authorization');
	next()

});
/*app.use("/",express.static(__dirname + '/public/administrator'));
app.use("/admin",express.static(__dirname + '/public/administrator'));
app.use("/phone",express.static(__dirname + '/public/phone'));
app.use("/sale",express.static(__dirname + '/public/sale'));
app.use("/templates",express.static(__dirname + '/templates'));
*/
app.use(bodyParser.urlencoded({
	extended: true
}));
app.use(bodyParser.json());
app.use(passport.initialize());
var server = require("http").Server(app);
//route
var route = require("./route");
route(app);
//start server
server.listen(port,function(){
	console.log("server start at " +port + " port");
});