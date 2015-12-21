var arrayfuncs = require("../../libs/array-funcs");
var model = require("../../models/hd1");
var controller = require("../../controllers/controller");
var async = require("async");
var ma_ct ='HD1';
module.exports = function(router){
	this.contr = new controller(router,model,ma_ct.toLowerCase(),{
		sort:		{ngay_ct:-1,so_ct:1}
	});
	this.contr.route();
}