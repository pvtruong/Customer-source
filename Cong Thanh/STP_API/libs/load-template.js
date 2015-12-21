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
var parseTemplate = require("./parse-template").parseTemplate;
module.exports = function(template,data,callback){
	template = "./templates/" + template;
	fs.readFile(template,function(error,html){
		if(error) return callback(error);
		
		html = html.toString();
		parseTemplate(html,data,callback);
	});
}