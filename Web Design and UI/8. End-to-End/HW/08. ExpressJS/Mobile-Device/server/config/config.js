'use strict';

let path = require('path'),
    rootPath = path.normalize(__dirname + '/../../');

module.exports = {
    development: {
        rootPath: rootPath,
        db: 'mongodb://localhost:27017/expressHW',
        port: process.env.PORT || 3030
    }
};