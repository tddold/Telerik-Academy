'use strict';

let auth = require('./auth'),
    controllers = require('../controllers'),
    services = require('../data/data-services'),
    dir = require('../data/data'),
    phones = dir.phones,
    tablets=dir.tablets,
    wearables= dir.wearables,
    fs = require('fs');

module.exports = function(app) {
    app.get('/upload', auth.isAuthenticated, function(req, res){
        res.render('categories/upload');
    });
    app.post('/upload', auth.isAuthenticated, function(req, res) {
        let fstream;
        req.pipe(req.busboy);
        req.busboy.on('file', function (fieldname, file, filename) {
            fstream = fs.createWriteStream('public/files/' + Math.random() + filename);
            file.pipe(fstream);
            fstream.on('close', function () {
                res.redirect('/upload-success/' + filename);
            });
        });
    });
    app.get('/upload-success/:newFileName', auth.isAuthenticated, function(req, res){
        res.render('upload-success', {newFileName: req.params.newFileName});
    });
    app.get('/register', controllers['users-controller'](app, services['users-data-service']).getRegister);
    app.post('/register', controllers['users-controller'](app, services['users-data-service']).postRegister);
    app.get('/login', controllers['users-controller'](app, services['users-data-service']).getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.isAuthenticated, auth.logout);
    app.get('/profile', auth.isAuthenticated, function(req, res){
        res.render('users/profile');
    });
    app.post('/profile', auth.isAuthenticated, controllers['users-controller'](app, services['users-data-service']).updateUser);
    app.get('/profile/delete/:id', auth.isAuthenticated, controllers['users-controller'](app, services['users-data-service']).deleteUser);
    app.get('/phones', function (req, res) {
        res.render('categories/phones', {title: 'Phones', data: phones});
    });
    app.get('/tablets', function (req, res) {
        res.render('categories/tablets', {title: 'Tablets', data: tablets});
    });
    app.get('/wearables', function (req, res) {
        res.render('categories/wearables', {title: 'Wearables', data: wearables});
    });

    /* GET home page. */
    app.get('/', function (req, res) {
        res.render('home', {
            title: 'Home'
        });
    });

    app.get('*', function(req, res) {
        res.redirect('/');
    });
};