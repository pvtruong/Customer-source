/*Copyright (C) 2015  Sao Tien Phong (http://saotienphong.com.vn)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
var nodemailer = require("nodemailer")
var systemConfig = require("../configs");
var mailAccount = require("../models/mailaccount");
var smtpTransport = require('nodemailer-smtp-transport');
var async = require('async')
var underscore = require('underscore')

var wellknown = require('nodemailer-wellknown');
	
exports.getAccount = function(account_id,done){
	mailAccount.findOne({_id:account_id}).lean().exec(function(e,account){
		if(e) return done(e)
		if(!account) return done("Don't find account " + account_id);
		done(null,account);
	})
}
exports.sendHtml = function(options,fn){
	var transporter,from
	//prepare sender
	if(options.account){
		var tp = options.account.smtp.host.split(".");
		var smtp,sender;
		if(tp.length>1){
			var server = tp[1];
			sender = wellknown(server);
		}
		
		if(!sender){
			sender ={
				host: options.account.smtp.host,
				port: options.account.smtp.port
			}
		}
		sender.auth = {
			user: options.account.username,
			pass: options.account.password
		}
		smtp = smtpTransport(sender);
		transporter = nodemailer.createTransport(smtp);
		//send by a account
		from ={name:options.account.fullname,address:options.account.username};
	}else{
		//send by system account
		transporter = nodemailer.createTransport(smtpTransport(systemConfig.sender));
		from ={name:systemConfig.sender.name,address:systemConfig.sender.auth.user};
		if(options.sender){
			from.name = options.sender;
		}
	}
	//prepare receivers and send
	if(underscore.isObject(options.to)){
		transporter.sendMail({
			from: from,
			to: options.to,
			subject: options.subject,
			html: options.html
		},function(error,info){
			fn(error,info);
		});
	}else{
		if(underscore.isArray(options.to)){
			async.map(options.to,function(to,callback){
				if(to.address){
					transporter.sendMail({
						from: from,
						to: to,
						subject: options.subject,
						html: options.html
					},function(error,info){
						callback(error,info);
					});
				}else{
					callback(null);
				}
			},function(error,t){
				fn(error,t);
			});
		}
	}
	
}