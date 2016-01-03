var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser'),
    mongoose = require('mongoose'),
    env = process.env.NOD_ENV || 'development',
    port = process.env.PORT || 3030,
    app = express(),
    db;

app.set('view engine', 'jade');
app.set('views', __dirname + '/server/views');
app.use(bodyParser.urlencoded({ extended: false }));
app.use(stylus.middleware({
    src: __dirname + '/public',
    compile: function (str, path) {
        return stylus(str).set('filename', path);
    }
}));

app.use(express.static(__dirname + '/public'));

// mongodb
if (env === 'development') {
    mongoose.connect('mongodb://localhost/means')
} else {
    mongoose.connect('mongodb://admin:means1234@ds037015.mongolab.com:37015/means');
}

db = mongoose.connection;

db.once('open', function (err) {
    if (err) {
        console.log('Database could not be opened: ' + err);
        return;
    }
    
    console.log('Database up and running...');
});

db.on('error', function (err) {
    console.log('Database error: ' + err);
});

app.get('/partials/:partialArea/:partialName', function (req, res) {
    res.render('../../public/app/' + req.params.partialArea + '/' + req.params.partialName);
});

app.get('*', function (req, res) {
    res.render('index');
});

app.listen(port);
console.log('Server running on port: ' + port);
