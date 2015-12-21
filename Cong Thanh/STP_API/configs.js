exports.domain = "http://localhost:8000"
exports.company ="Sao Tiên Phong"
var program ="STP Accounting"
exports.program = program;
exports.version ="0.0.1"
exports.PORT ='8000'
//emai sender
var wellknown = require('nodemailer-wellknown');
var underscore = require('underscore')
var sender = wellknown('Gmail');
sender.auth = {
		user: 'email he thong',
		pass: 'mat khau'
	}
sender.name =program;
exports.sender = sender;
//sql server
exports.sqlconfig = {
    user: 'sa',
    password: 'STP!@#$%^123456',
    server: 'VT_SERVER', // You can use 'localhost\\instance' to connect to named instance
    database: 'STP_VANTAI',
	connectionTimeout:0,
	requestTimeout:0,
	pool: {
        max: 10,
        min: 0,
        idleTimeoutMillis: 30000
    }
   /* options: {
        encrypt: true // Use this if you're on Windows Azure
    }
	*/
}