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

var underscore = require("underscore");
var fs = require("fs");
var path = require("path")
var moment = require("moment")
var controllerRPT = function(router,rptId,getData,options){
	if(!options) options ={}
	this.module = rptId
	var module = this.module;
	var base_path = "/";
	router.route(base_path + this.module).get(function(req,res,next){
		getData(req,function(error,data){
            if(error) return res.status(400).send(error);
            res.send(data);
        });
		
	});
}
module.exports = controllerRPT;