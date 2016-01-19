'use strict';

let fs = require('fs'),
    path = './server/data/data-services',
    services = {};

(function() {
    console.log('Loading services...');
    fs.readdirSync(path)
        .filter(file => file.indexOf('service') !== -1)
        .forEach(file => {
            let serviceName = file.substring(0, file.lastIndexOf('.'));
            services[`${serviceName}`] = require('./' + file);
        });
}());

module.exports = services;