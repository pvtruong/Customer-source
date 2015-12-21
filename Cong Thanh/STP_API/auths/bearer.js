var sql = require("../libs/sqlserver");
var underscore = require("underscore");
var BearerStrategy = require('passport-http-bearer').Strategy;
module.exports = function(passport){
	function findByToken(token, fn) {
	  var query ="select rtrim(id) as id,rtrim(idname) as idname from dmnsd where id in (select id from tokens where token='" + token + "')"
	  sql.findOne(query,function(error,user){
		if(error) return fn(error);
		if(user) {
			user.current_user = user.email;
			user.token = token;
			return fn(null,user);
		}
		return fn(null, null);
	  });
	  
	}
	passport.use(new BearerStrategy({},
	  function(token, done) {
		process.nextTick(function () {
		  findByToken(token, function(err, user) {
			if (err) { return done(err); }
			if (!user) {
				console.log("Not found token " + token);
				return done(null, false); 
			}
			return done(null, user);
		  })
		});
	  }
	));
}