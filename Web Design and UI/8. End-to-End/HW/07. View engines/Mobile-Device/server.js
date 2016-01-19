"use strict";

let express = require('express'),
    morgon = require('morgan'),
    path = require('path'),
    routes = require('./routes'),
    port = process.env.PORT || 3939,
    favicon = require('serve-favicon'),
    app = express();

// view engine
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'jade')

app.use(morgon('dev'));
app.use(favicon(__dirname + '/public/favicon.ico'));

app.use('/', routes);

app.listen(port);
console.log('Server running on port: ' + port);


