(function () {
    "use strict";

    var chatDb = require('./chat-db');


/*
    chatDb.registerUser({
        name: 'DonchoMinkov',
        password: '123456q'
    });

    chatDb.registerUser({
        name: 'NikolayKostov',
        password: '123456q'
    });*/

    chatDb.sendMessage({
        from: 'DonchoMinkov',
        to: 'NikolayKostov',
        text: 'Hey, Niki!'
    });

    chatDb.sendMessage({
        from: 'NikolayKostov',
        to: 'DonchoMinkov',
        text: 'Hey, Doncho!'
    });

    chatDb.getMessages({
        with: 'DonchoMinkov',
        and: 'NikolayKostov'
    }).then(function(res){
        console.log(`All messages: ${res}`);
        db.disconnect();
    });
}());