
var BasicStrategy = require('passport-http').BasicStrategy;
var underscore = require("underscore");
var crypto = require('crypto');
var sql = require("../libs/sqlserver");
var loadTemplate = require("../libs/load-template");
module.exports = function(app,passport){
	function findByUsername(username, fn){
	  if( !username) return fn(null,null);
	  var username = username.toLowerCase();
	  var query ="select * from dmnsd where id='" + username + "'"
	  sql.findOne(query,function(error,result){
		if(error || !result) return fn(error,null);
		return fn(null,result);
	  });
	}
	function getToken(username,password,done){
		process.nextTick(function() {
			findByUsername(username, function(err, user) {
				if (err) { return done(err); }
				if (!user) { return done("Tài khoản " + username + " không tồn tại."); }
				if (!user.password_api || user.password_api!=password) { return done("Mật khẩu không chính xác."); }
				
				var n = new Date();
				var accessToken =crypto.createHash('md5').update(user.password_api + user.email + n.toISOString()).digest('hex');
				user.token = accessToken;
				var query ="delete tokens where id='" + username + "'\n insert into tokens (id,token,date_created) values('" + username + "','" + accessToken + "',getdate())" 
				sql.execute(query,function(e,rs){
					if(e) return done(e)
					return done(null, user);
				})
			  })
		})
	}
	passport.use(new BasicStrategy(
	  getToken
	));

	app.get('/auth/local',
		passport.authenticate('basic', { session: false }),
		function(req, res){
			var user = req.user;
			res.send(user.token);
		}
	);
	app.get('/auth/token',function(req,res,next){
		var user = req.query.user;
		var password = req.query.password;
		getToken(user,password,function(e,user){
			if(e) return res.status(400).send(e);
			res.send(user.token)
		})
	});
	
 }