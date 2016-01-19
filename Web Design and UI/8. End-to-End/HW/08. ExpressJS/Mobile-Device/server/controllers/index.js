'use strict';

let fs = require('fs'),
    path = './server/controllers',
    controllers = {};

(function() {
    console.log('Loading controllers...');
    fs.readdirSync(path)
        .filter(file => file.indexOf('controller') !== -1)
        .forEach(file => {
            let controllerName = file.substring(0, file.lastIndexOf('.'));
            controllers[`${controllerName}`] = require('./' + file);
        });
}());

module.exports = controllers;