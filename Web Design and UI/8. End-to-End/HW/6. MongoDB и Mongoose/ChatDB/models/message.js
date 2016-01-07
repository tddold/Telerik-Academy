(function () {
    'use strict';

    var  mongoose = require('mongoose'),
        schema = new mongoose.Schema({
            from:{
                type:String,
                required:true,
                min:2
            },
            to:{
                type:String,
                required:true,
                min:2
            },
            text:{
                type:String,
                required:true
            }
        });

    mongoose.model('Message', schema);
}());