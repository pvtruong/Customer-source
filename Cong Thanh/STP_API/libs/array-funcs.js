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
var _ = require("underscore");
var async = require("async");

/**
 * Sums a column in the array (table).
 * @param {String} field A column in the table.
 * @param {Object} condition A dictionary to filter the array with.
 * @return {Number} Returns the sum.
 */
Array.prototype.csum = function(field, condition) {
	return _.reduce(this, function(sum, row) {
		if (_.isMatch(row, condition)) {
			// If the field value can't be converted then use 0
			return sum + (Number(row[field]) || 0);
		} else {
			return sum;
		}
	}, 0);
};

Array.prototype.groupBy=function(fieldkey,fieldsums,fn){
	var groups = _.groupBy(this,function(item){
		return item[fieldkey];
	});
	async.map(_.keys(groups)
		,function(key,callback){
			var value = groups[key];
			var r = {};
			r[fieldkey] = key;
			fieldsums.forEach(function(f){
				if(_.isObject(f)){
					r[f.name] = value.csum(f.value);
				}else{
					r[f] = value.csum(f);
				}
				
			});
			callback(null,r);
			
		},function(error,result){
			if(error) return fn(error);
			fn(null,result);
		}
	)
}
Array.prototype.joinModel = function(id_app,model,joinFields,fn){
	if(_.isArray(id_app)){
		model_1 = id_app;
		joinFields_1 = model;
		fn_1 = joinFields;
		id_app_1 = undefined;
		
		id_app = id_app_1;
		model = model_1;
		joinFields = joinFields_1;
		fn = fn_1;

	}
	var array = this;	
	async.map(array,function(a,callback){
		async.map(joinFields,function(join,callback){
			var query ={};
			if(join.where){
				for(var bkey in join.where){
					var akey = join.where[bkey];
					query[bkey] = a[akey]
					
					if(bkey=='_id' && !a[akey]){
						return callback(null);
					}
				}
				
			}
			if(join.akey && join.bkey){
				if( join.bkey=='_id' && !a[join.akey]){
					return callback(null);
				}
				query[join.bkey] = a[join.akey];
			}
			
			if(_.isArray(model)){
				b = _.findWhere(model,query);
				if(b && join.fields){
					join.fields.forEach(function(map){
						var name = map.name;
						var value = map.value;
						a[name] = b[value];
					});
					
				}
				callback(null);
			}else{
			   query.id_app = id_app;
			   model.findOne(query).lean().exec(function(error,b){
					if(error) return callback(error);
					if(b && join.fields){
						join.fields.forEach(function(map){
							var name = map.name;
							var value = map.value;
							a[name] = b[value];
						});
					}
					callback(null);
				});
			}
		},function(error,rs){
			if(error) return callback(error);
			callback();
		});
	},function(error,kqs){
		if(error) console.log(error);
		fn(array);
	});
}
