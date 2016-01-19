var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser'),
    cookieParser = require('cookie-parser'),
    session = require('express-session'),
    passport = require('passport'),
    STATIC_DIRECTORY = '/public',
    secretPassPhrase = 'SequGcJeUcAXR7SymwXMmW6kDr8aYH86jCrwE8UdC7n';;

module.exports = function (app, config) {
    app.set('view engine', 'jade');
    app.set('views', config.rootPath + '/server/views');
    app.use(cookieParser(secretPassPhrase));
    app.use(bodyParser.json());
    app.use(bodyParser.urlencoded({ extended: true }));
    app.use(session({
        secret: secretPassPhrase,
        saveUninitialized: true,
        resave: true
    }));
    app.use(stylus.middleware({
        src: config.rootPath + '/public',
        compile: function (str, path) {
            return stylus(str).set('filename', path);
        }
    }));
    
    app.use(passport.initialize());
    app.use(passport.session());
    app.use(express.static(config.rootPath + STATIC_DIRECTORY));
    app.use(function (req, res, next) {
        console.log(req.user);
        next();
    });
};
