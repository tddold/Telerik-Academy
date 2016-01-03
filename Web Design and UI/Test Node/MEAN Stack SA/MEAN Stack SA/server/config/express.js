var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser');

module.exports = function (app, config) {
    app.set('view engine', 'jade');
    app.set('views', config.rootPath + '/server/views');
    app.use(bodyParser.urlencoded({ extended: false }));
    app.use(stylus.middleware({
        src: config.rootPath + '/public',
        compile: function (str, path) {
            return stylus(str).set('filename', path);
        }
    }));
    
    app.use(express.static(config.rootPath + '/public'));
};
