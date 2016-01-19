﻿var express = require('express'),
    app,
    env,
    config;

env = process.env.NOD_ENV || 'development';
app = express();

config = require('./server/config/config')[env];

require('./server/config/express')(app, config);
require('./server/config/mongoose')(config);
require('./server/config/passport')();
require('./server/config/routes')(app);

app.listen(config.port);
console.log('Server running on port: ' + config.port);