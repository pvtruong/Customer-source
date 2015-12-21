var Vschema =require("./vschema");
var Model =require("./model");
var vatrachema = new Vschema({
	loai_ct:{type:'String',maxLength:2,default:'',required:true},
	ngay_hd:{type:'Date',required:true},
	so_hd:{type:'String',maxLength:16,required:true},
	so_seri:{type:'String',maxLength:16,required:true},
	ten_kh:{type:'String',maxLength:128,default:''},
	dia_chi:{type:'String',maxLength:64,default:''},
	ma_so_thue:{type:'String',maxLength:16,default:''},
	ma_kh2:{type:'String',maxLength:16,default:''},
	ten_vt:{type:'String',maxLength:128,default:''},
	
	t_tien_nt:{type:'Number',default:0},
	t_tien:{type:'Number',default:0},
	
	ma_thue:{type:'String',maxLength:16,required:true},
	thue_suat:{type:'Number',default:0},
	
	t_thue_nt:{type:'Number',default:0},
	t_thue:{type:'Number',default:0},
	
	tk_thue_co:{type:'String',maxLength:16,required:true},
	tk_du:{type:'String',maxLength:16,required:true},
	
	line:{type:'Number',default:0,required:true},
	status:{type:'Boolean',default:true},
	
	ghi_chu:{type:'String',maxLength:64,default:''},
	ma_kh: {type:'String',maxLength:16,default:''},
	ma_bp: {type:'String',maxLength:16,default:''},
	ma_phi: {type:'String',maxLength:16,default:''},
	ma_dt: {type:'String',maxLength:16,default:''},
	ma_hd: {type:'String',maxLength:16,default:''},
},'vatra')
module.exports = Model.create(vatrachema,{
	onSave:function(data,callback){
		data.forEach(function(d){
			if(d.ma_nt=='VND'){
				d.t_tien = d.t_tien_nt;
				d.t_thue = d.t_thue_nt;
			}
		})
		callback()
	}
});