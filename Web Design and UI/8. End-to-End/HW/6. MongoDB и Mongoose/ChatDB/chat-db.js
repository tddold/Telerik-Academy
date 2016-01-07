(function () {
    "use strict";

    var fs = require('fs'),
        db = require('./db-config'),
        mongoose = require('mongoose'),
        modelsPath,
        User,
        Message;


    modelsPath = __dirname + '/models';
    fs.readdirSync(modelsPath)
        .forEach(function (file) {
            if (file.indexOf('.js') >= 0) {
                require(modelsPath + '/' + file);
            }
    });


    User = mongoose.model('User');
    Message = mongoose.model('Message');


    function registerUser(obj){
        if(!obj || typeof obj !== 'object'){
            console.log('Invalid user');
            return;
        }

        var user = new User({
            name: obj.name,
            password: obj.password
        });

        User.find()
            .where('user').equals(obj.user)
            .exec(function (err, data) {
                if (err){
                    throw err;
                }

                if (data.length !== 0){
                    throw  'User already exist';
                    return;
                }

                user.save(function(err){
                    if(err){
                        console.log(err);
                        throw err;
                    }

                    console.log('User added');
                });
            });
    }

    function sendMessage(messageObj){
        if(!messageObj || typeof messageObj !== 'object'){
            console.log('Inavalid message');
            return;
        }

        var newMessage = new Message(messageObj);
        newMessage.save(function (err, addedMessage) {
            if(err){
                return console.error(err);
            }

            console.log(`Message id=${addedMessage._id} sent successfullu!`);
        });
    }

    function getMessages(user){
        if(!user || typeof user !== 'object'){
            console.log('Invalid user');
            return;
        }

        return Message.find()
            .where('from').in([user.with, user.and])
            .where('to').in([user.with, user.and])
            .exec(function (err, receivedMessages) {
                if (err){
                    console.log(err);
                    return;
                }

                console.log(`${receivedMessages.length} messages  between ${user.with} and ${user.and} received.`);
            });
    }

    module.exports = {
        registerUser,
        sendMessage,
        getMessages,
        db
    }
}());