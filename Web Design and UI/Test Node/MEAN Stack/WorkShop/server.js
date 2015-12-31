var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser'),
    env = process.env.NODE_ENV || 'development',
    port = 3030,
    app = express();

app.set('view engine', 'jade');
app.set('views', __dirname + '/server/views');
app.use(bodyParser());
app.use(stylus.middleware({
    src: __dirname + '/public',
    compile: function (str, path) {
        return stylus(str).set('filename', path);
    }
}));

app.use(express.static(__dirname + '/public'));

//app.get('/partials/:partialName', function (req, res) {
//    res.render('partials/', req.params.partialName);
//});

app.get('*', function (req, res) {
    res.render('index');
});

app.listen(port);
console.log('Server running on port: ' + port);
