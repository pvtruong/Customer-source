var underscore = require("underscore")
var Schema = require("./schema")
var VSchema = function(schema,name){
	var defaults ={
		stt_rec : {type:'String',maxLength:13,required:true},
		ma_dvcs: {type:'String',maxLength:16,required:true},
		ma_ct:{type:'String',maxLength:3,required:true},
		so_ct : {type:'String',maxLength:16,required:true},
		ngay_ct : {type:'Date',default:new Date(),required:true},
		ma_nt : {type:'String',maxLength:3,default:'VND',required:true},
		ty_gia : {type:'Number',default:1,required:true},
		
		ngay_tao : {type:'DateTime',default:new Date()},
		ngay_sua : {type:'DateTime',default:new Date()},
		nguoi_tao : {type:'String',maxLength:16,default:''},
		nguoi_sua : {type:'String',maxLength:16,default:''},
		status : {type:'Number',default:5,required:true}
	}
	if(schema){
		underscore.extend(defaults,schema);
	}
	Schema.call(this,defaults,name)
}
VSchema.prototype = new Schema;
module.exports = VSchema;