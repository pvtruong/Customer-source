
var underscore = require('underscore');
var async = require('async');
var controller = require('../../controllers/controllerRPT');
var sql = require("../../libs/sqlserver")
module.exports = function(router) {
	var rpt = new controller(router, 'thongtindieuxe', function(req, callback) {
	    var so_xe = req.query.so_xe;
		var query ="exec api_dieuxe '" + so_xe + "'";
        sql.query(query,function(e,rs){
            if(e) return callback(e);
            if(rs.length>0){
                var obj = rs[0];
                var html ="<html>";
                html = html + "<head><meta charset='utf-8''/><title>Thông tin điều xe</title> <style> table td,th {border:1px solid gray;padding:5px}</style></head>";
                html = html + "<body>";
                html = html + "<table><tr><th>Name</th><th>Value</th></tr>";
                
                html = html + "<tr><td>TÊN XE</td><td>" + obj.ten_xe + "</td></tr>";
                html = html + "<tr><td>SỐ MOOC</td><td>" + obj.so_mooc + "</td></tr>";
                html = html + "<tr><td>MÃ KHÁCH HÀNG</td><td>" + obj.ten_kh + "</td></tr>";
                html = html + "<tr><td>LOẠI HÌNH</td><td>" + obj.loai_hinh + "</td></tr>";
                html = html + "<tr><td>SỐ CONT</td><td>" + obj.so_cont + "</td></tr>";
                html = html + "<tr><td>SỐ BOOKING</td><td>" + obj.so_booking + "</td></tr>";
                html = html + "<tr><td>CLOSING TIME</td><td>" + obj.closing_time + "</td></tr>";
                html = html + "<tr><td>SỐ KẾ HOẠCH</td><td>" + obj.so_ke_hoach + "</td></tr>";
                
                html = html + "</table>";
                 html = html + "</body>";
                html = html + "</html>";
                callback(null,html);
            }else{
                callback("Xe này không tồn tại hoặc không tìm thấy phiếu điều xe của xe này");
            }
        })
	});
};