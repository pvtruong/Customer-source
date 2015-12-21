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
var email = require("./email");
var loadTemplate = require("./load-template");
var parseTemplate = require("./parse-template").parseTemplate;
var async = require("async");
var mailschedule = require("../models/mailschedule");
var Mailsent = require("../models/mailsent");
var Contract = require("../models/contract");
var Customer = require("../models/customer");
var Lienhe = require("../models/lienhe");
var Link = require("../models/link");
var spawn = require("child_process").spawn;
var App = require("../models/app");
var underscore = require("underscore");
//define schedule
exports.define = function(){
	//backup
	agenda.define("Backup",{priority: 'low', concurrency: 1},function(job,done){
		var backup_file = __dirname + "/backup.js";
		var p = spawn('node',[backup_file]);
		p.stdout.on("data",function(data){
			data = data.toString();
			if(data==1){
				console.log("Backup database completed");
			}else{
				console.log("Log:",data);
			}
		})
		p.stderr.on("data",function(data){
			console.log("Error:",data.toString());
		})
		p.on("close",function(code){
			done();
		})
	});
	//warranty
	agenda.define("Warranty",{priority: 'high', concurrency: 50},function(job,done){
		var obj = job.attrs.data.obj;
		//send to user created
		obj.to =[{name:obj.user_created,address:obj.user_created}];
		//send to visible users
		if(obj.visible_to_users){
			obj.visible_to_users.forEach(function(u){
				obj.to.push({name:u,address:u});
			})
		}
		//get contract info
		Contract.findOne({_id:obj.id_hd}).lean().exec(function(e,contract){
			if(e || !contract) return console.error("Can't get contract info ",obj.id_hd," ",e);
			obj.contract = contract;
			//get customer info
			Customer.findOne({_id:contract.id_kh}).lean().exec(function(e,customer){
				if(e || !customer) return console.error("can't get customer info ",contact.id_kh, " ",e);
				obj.customer = customer
				//get app info
				App.findOne({_id:customer.id_app}).lean().exec(function(e,company){
					if(e || !company) return console.error("can't get company info ",contact.id_app, " ",e);
					obj.company = company;
					//send
					loadTemplate("alert warranty.html",obj,function(error,html){
						email.sendHtml({to:obj.to,subject:"Thông báo hợp đồng đến hạn bảo hành",html:html},function(error,info){
							if(error) {
								console.error("Khong the gui email nhac nho bao hanh\n" + error);
							}
							done();
						});
					});
				});
			})
		})
	});
	//task
	agenda.define("Task",{priority: 'high', concurrency: 50},function(job,done){
		var obj = job.attrs.data.obj;
		loadTemplate("alert task.html",obj,function(error,html){
			var to = obj.attends;
			if(!to || to.length==0){
				to =[{name:obj.ten_phu_trach,address:obj.phu_trach}]
			}
			email.sendHtml({to:to,subject:"Nhắc nhở công việc",html:html},function(error,info){
				if(error) {
					console.error("Khong the gui email nhac nho cong viec\n" + error);
				}
				done();
			});
		});
	});
	//send email
	agenda.define("SendEmail",{priority: 'high', concurrency: 20},function(job,done){
		//begin send email
		var obj = job.attrs.data.obj;
		email.getAccount(obj.account_id,function(e,account){
			if(e){
				console.error(e);
				return done();
			}
			async.map(obj.to,function(to,callback){
				var obj4parse = {}
				underscore.extend(obj4parse,obj);
				obj4parse.receiver = to;
				parseTemplate(obj4parse.mail.html,obj4parse,function(error,html){
					if(e) return callback(e);
					email.sendHtml({account:account,to:to,subject:obj4parse.subject,html:html},function(error,info){
						if(error) {
							error = error.toString();
							if(error.indexOf('ENOTFOUND')>=0){
								callback(error);
							}else{
								callback();
							}
							
						}else{
							//save mail sent
							obj4parse.mail.html = html;
							obj4parse.mail.text = obj4parse.mail.html.replace(/<(?:.|\n)*?>/gm, '');
							
							if(obj4parse.mail.text){
								if(obj4parse.mail.text.length>128){
									obj4parse.small_text = obj4parse.mail.text.substring(0,128) + "...";
								}else{
									obj4parse.small_text = obj4parse.mail.text;
								}
							}
							obj4parse.to=[to]
							obj4parse.date_created = new Date();
							obj4parse.date_updated = new Date();
							delete obj4parse._id;
							
							var mailsent = new Mailsent(obj4parse)
							mailsent.save(function(e,sent){
								if(e) return console.log(e)
								//create link
								async.parallel({
									contact:function(callback){
										Lienhe.find({email:to.address,id_app:sent.id_app}).lean().exec(function(e,lhs){
											if(lhs){
												async.map(lhs,function(lh,callback){
													var link = new Link({id_app:sent.id_app,collection_a:'lienhe',id_a:lh._id,collection_b:'mailsent',id_b:sent._id});
													link.save(function(e){
														if(e) console.log(e)
															callback();
													})
												},function(e,rs){
													callback()
												})
											}else{
												callback()
											}
										})
									},
									cust:function(callback){
										Customer.find({email:to.address,id_app:sent.id_app}).lean().exec(function(e,lhs){
											if(lhs){
												async.map(lhs,function(lh,callback){
													var link = new Link({id_app:sent.id_app,collection_a:'customer',id_a:lh._id,collection_b:'mailsent',id_b:sent._id});
													link.save(function(e){
														if(e) console.log(e)
															callback();
													})
												},function(e,rs){
													callback()
												})
											}else{
												callback()
											}
										})
									}
									
								},function(e,r){
									//callback(e,r)
								})
							})
							callback();
						}
					});
				})
			},function(e,rs){
				//if no repeat then delete 
				if(!e){
					if(obj.repeat==0){
						mailschedule.remove({_id:obj._id},function(e){
							if(e) console.log("Can't delete mail which sent:",e)
						})
					}else{
						mailschedule.update({_id:obj._id},{error:"",sent:true,nextRunAt:job.attrs.nextRunAt},function(e,rs){
							if(e) console.log(e);
						})
					}
				}else{
					console.log(e)
					mailschedule.update({_id:obj._id},{error:e,sent:false,date_updated:new Date(),nextRunAt:job.attrs.nextRunAt},function(e,rs){
						if(e) return console.log(e);
					})
				}
				done()
			})
			
		})
		
	});
}
exports.getJob = function(name,_id,next){
	agenda.jobs({name:name}, function(err, jobs) {
	  if(err) return next(err);
	  if(jobs){
		  for(var i=0;i<jobs.length;i++){
			var job = jobs[i];
			if(job.attrs.data.id==_id.toString()){
				return next(null,job);
			}  
		  }
	  }
	   next("Not found");
	});
}
exports.deleteTaskJob = function(_id,next){
	exports.deleteJob("Task",_id,next);
}
exports.deleteWarrantyJob = function(_id,next){
	exports.deleteJob("Warranty",_id,next);
}
exports.deleteMailJob = function(_id,next){
	exports.deleteJob("SendEmail",_id,next);
}
exports.deleteJob = function(name,_id,next){
	if(!next) next = function(){};
	agenda.jobs({name:name}, function(err, jobs) {
	  if(err) return next(err);
	  if(jobs){
		  async.map(jobs,function(job,callback){
			  if(job.attrs.data.id==_id.toString()){
				job.remove(function(err) {
						if(err) console.log("Can't remove job\n" + err);
						callback(err);
				  })  
			  }else{
				  callback();
			  }
			  
		  },function(e,rs){
			 next(e,rs); 
		  });
	  }else{
		  next()
	  }
	});
}
exports.createTaskJob = function(obj){
	exports.createJob("Task",obj);
}
exports.createWarrantyJob = function(obj){
	var reminder = obj.start_date;
	if(obj.unit_time==1){
		reminder.setDate(reminder.getDate() + obj.warranty_time);
		obj.unit_time_name ="ngày"
	}
	if(obj.unit_time==2){
		reminder.setMonth(reminder.getMonth() + obj.warranty_time);
		obj.unit_time_name ="tháng"
	}
	if(obj.unit_time==3){
		obj.unit_time_name ="năm"
		reminder.setYear(reminder.getYear() + obj.warranty_time);
	} 
	obj.reminder = reminder;
	exports.createJob("Warranty",obj);
}
exports.createMailJob = function(obj){
	exports.createJob("SendEmail",obj);
}
exports.createBackupJob = function(schedule,repeat){
	if(!repeat) repeat =1;
	var obj ={_id:'backup',schedule:schedule,repeat:repeat};
	exports.createJob("Backup",obj);
}
exports.createJob = function(name,obj){
	//create schedule
	if(obj.reminder && !obj.schedule){
		obj.schedule = obj.reminder;
	}
	if(obj.schedule){
		exports.getJob(name,obj._id,function(e,job){
			if(!job){
				job = agenda.create(name,{obj: obj,id:obj._id.toString()});
				job.schedule(obj.schedule);
			}else{
				job.attrs.data.obj = obj;
				if(!job.attrs.lastRunAt || (job.attrs.lastRunAt && job.attrs.lastRunAt.getTime()<obj.schedule.getTime())){
					job.schedule(obj.schedule);
				}
			}
			if(obj.repeat){
				//days,weeks, months
				var time_repeat;
				if(obj.repeat==1){
					time_repeat="1 day";
				}
				if(obj.repeat==2){
					time_repeat="1 week";
				}
				if(obj.repeat==3){
					time_repeat="1 month";
				}
				if(obj.repeat==4){
					time_repeat="3 months";
				}
				if(obj.repeat==5){
					time_repeat="12 months";
				}
				
				if(time_repeat){
					job.repeatEvery(time_repeat);
				}
				
				
			}
			job.save(function(e){
				if(e) console.log(e);
			});
		})
	}else{
		exports.deleteJob(name,obj._id);
	}
}