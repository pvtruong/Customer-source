var underscore = require("underscore")
var Schema = require("./schema")
var DSchema = function(schema,name){
	var defaults ={
		stt_rec : {type:'String',maxLength:13,required:true},
		so_ct : {type:'String',maxLength:16,required:true},
		ngay_ct : {type:'Date',required:true},
		ma_nt : {type:'String',maxLength:3,required:true},
		ty_gia : {type:'Number',required:true}
	}
	if(schema){
		underscore.extend(defaults,schema);
	}
	Schema.call(this,defaults,name)
}
DSchema.prototype = new Schema;
module.exports = DSchema;