var Vschema =require("./vschema");
var Dschema =require("./dschema");
var vatra =require("./vatra");
var Model =require("./model");
var MHD1Schema = new Vschema({
	dien_giai: {type:'String',maxLength:128,default:''},
	ma_kh:{type:'String',maxLength:16,default:''},
	ma_ct:{type:'String',maxLength:3,default:'HD1',required:true},
	ma_gd:{type:'Number',default:0,required:true}
},'mhd1')
var DHD1Schema = new Dschema({
	ma_ct:{type:'String',maxLength:3,default:'HD1',required:true},
	tk_no:{type:'String',maxLength:16,required:true},
	tk_co:{type:'String',maxLength:16,required:true},
	tien_nt:{type:'Number',default:0},
	tien:{type:'Number',default:0},
	
	ty_le_ck:{type:'Number',default:0},
	tien_ck:{type:'Number',default:0},
	tien_ck_nt:{type:'Number',default:0},
	tk_ck:{type:'String',maxLength:16,default:''},
	
	dien_giai: {type:'String',maxLength:128,default:''},
	ma_kh: {type:'String',maxLength:16,default:''},
	ma_bp: {type:'String',maxLength:16,default:''},
	ma_phi: {type:'String',maxLength:16,default:''},
	ma_dt: {type:'String',maxLength:16,default:''},
	ma_hd: {type:'String',maxLength:16,default:''},
},'dhd1')
var detail = Model.create(DHD1Schema,{
	onSave:function(data,callback){
		data.forEach(function(d){
			if(d.ma_nt=='VND'){
				d.tien = d.tien_nt;
				d.tien_ck = d.tien_ck_nt;
			}
		})
		callback()
	}
});
module.exports = Model.create(MHD1Schema,{
	modelDetails:{
		detail:detail,
		vatra:vatra
	}
});