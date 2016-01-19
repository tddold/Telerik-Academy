"use strict";

let express = require('express'),
    router = express.Router(),
    fs = require('fs'),
    path = require('path'),
    dirPath,
    dir = require('../public/data/data'),
    phones = dir.phones,
    tablets=dir.tablets,
    wearables= dir.wearables;

router.get('/phones', function (req, res) {
    res.render('phones', {title:'Phones', data: phones});
});

router.get('/tablets', function (req, res) {
    res.render('tablets', {title: 'Tablets', data: tablets});
});

router.get('/wearables', function (req, res) {
    res.render('wearables', {title: 'Wearables', data: wearables});
});

/* GET home page. */
router.get('/', function (req, res) {
    res.render('home', {
        title: 'Home'
    });
});

module .exports = router;