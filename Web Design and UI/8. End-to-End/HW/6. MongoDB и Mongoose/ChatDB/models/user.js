(function () {
   'use strict';

    var mongoose = require('mongoose'),
        schema = new mongoose.Schema({
            name:{
                type:String,
                required:true
                // min:2
            },
            password:{
                type:String,
                required:true
                // min:6
            }
        });

    mongoose.model('User',schema);
}());