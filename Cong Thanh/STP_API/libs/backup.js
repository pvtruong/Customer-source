var configs = require("../configs");
var mongodb_backup = require("mongodb-backup");
var fs = require("fs");
var path = require("path");

var dir = path.join(path.dirname(__dirname),"backup");
if(!fs.existsSync(dir)){
	fs.mkdirSync(dir);
}
var now = new Date();
var tar_file = now.getFullYear() + "_" +  (now.getMonth()+1) + "_" + now.getDate() + ".tar"
var logger = path.join(dir,"log.txt")
console.log("Backup database...")
mongodb_backup({
  uri: configs.database.url,
  root: dir,
  tar: tar_file,
  logger:logger,
  callback:function(){
	console.log(1)
  }
})
