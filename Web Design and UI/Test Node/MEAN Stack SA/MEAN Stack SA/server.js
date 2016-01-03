var express = require('express'),
    stylus = require('stylus'),
    bodyParser = require('body-parser'),
    mongoose = require('mongoose'),
    env = process.env.NOD_ENV || 'development',
    port = process.env.PORT || 3030,
    app = express(),
    messageSchema,
    messageFromDataBase,
    Message,
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
    console.log('development');
    mongoose.connect('mongodb://localhost/means')
} else {
    console.log('production');
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

messageSchema = mongoose.Schema({
    message: String
})

Message = mongoose.model('Message', messageSchema);

Message.remove({})
    .exec(function (err) {
    if (err) {
        console.log('Message could not be cleared: ' + err);
        return;
    }
    
    console.log('Messages deleted!');
    
    Message.create({ message: 'Hi for Mongoose!' })
        .then(function (model) {
        if (err) {
            console.log('Cannot be created database: ' + err);
            return;
        }
        
        messageFromDataBase = model.message;
        console.log(model.message);
    });
});

app.get('/partials/:partialName', function (req, res) {
    res.render('partials/' + req.params.partialName);
});

app.get('*', function (req, res) {
    res.render('index', { message: messageFromDataBase });
});

app.listen(port);
console.log('Server running on port: ' + port);
console.log(env);
