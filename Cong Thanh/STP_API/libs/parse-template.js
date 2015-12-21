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
var fs = require("fs");
var underscore = require("underscore");
var configs = require("../configs");
exports.parseTemplate = function(html,data,callback){
	html = html.replace(new RegExp("{{domain}}", 'g'),configs.domain);
	html = html.replace(new RegExp("{{program}}", 'g'),configs.program);
	html = html.replace(new RegExp("{{company}}", 'g'),configs.company);
	
	for(var key in data){
		var da = data[key];
		if(underscore.isObject(da) && !underscore.isDate(da)){
			for(var k in da){
				var d = da[k]
				if(d){
					var D,DT;
					if(underscore.isDate(d)){
						D = d.getDate().toString() + "/" + (d.getMonth() + 1) + "/" + d.getFullYear().toString()
						DT = d.getDate().toString() + "/" + (d.getMonth() + 1) + "/" + d.getFullYear().toString() + " " + d.getHours().toString() + " giờ " + d.getMinutes().toString() + " phút" 
						
						html = html.replace(new RegExp("{{" + key + "."  + k + "###}}", 'g'),D);
						html = html.replace(new RegExp("{{" + key + "."  + k + "}}", 'g'),DT);
					}else{
						html = html.replace(new RegExp("{{" + key + "."  + k + "}}", 'g'),d.toString());
					}
					
				}
			}
		}else{
			
			if(da){
				if(underscore.isDate(da)){
					var D,DT;
					DT = da.getDate().toString() + "/" + (da.getMonth() + 1) + "/" + da.getFullYear().toString() + " " + da.getHours().toString() + " giờ " + da.getMinutes().toString() + " phút" 
					D = da.getDate().toString() + "/" + (da.getMonth() + 1) + "/" + da.getFullYear().toString()
					html = html.replace(new RegExp("{{" + key + "###}}", 'g'),D);
					html = html.replace(new RegExp("{{" + key + "}}", 'g'),DT);
				}else{
					html = html.replace(new RegExp("{{" + key + "}}", 'g'),da.toString());
					
				}
				
			}
			
		}
		html = html.replace(new RegExp("{{" + key + "}}", 'g'),"");
	}
	callback(null,html);
}
