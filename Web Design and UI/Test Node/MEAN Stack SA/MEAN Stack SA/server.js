var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser'),
    mogoose = require('mongoose'),
    env = process.env.NOD_ENV || 'development',
    port = process.env.PORT || 3030,
    app = express(),
    messageSchema,
    messageFromDataBase,
    Message,
    db;

debugger;

app.set('view engine', 'jade');
app.set('view', __dirname + '/server/view');


app.use(express.static(__dirname + '/public'));



app.get('/partials/:partialName', function (req, res) {
    res.render('partials/' + req.params.partialName);
});

app.get('*', function (req, res) {
    res.render('index', { message: messageFromDataBase });
});

app.listen(port);
console.log('Server running on port: ' + port);
console.log(env);
