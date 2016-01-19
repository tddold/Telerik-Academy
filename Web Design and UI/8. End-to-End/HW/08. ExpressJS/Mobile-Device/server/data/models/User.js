'use strict';

let mongoose = require('mongoose'),
    encryption = require('../../utilities/encryption'),
    userRoles = ['user', 'admin'],
    forbiddenCharacters = [' ', '<', '>', '(', ')', ','];

module.exports.init = function() {
    let userSchema = mongoose.Schema({
        username: {
            type: String,
            minlength: 3,
            required: true,
            index: {
                unique: true
            },
            validate: {
                validator: function (val) {
                    'use strict';
                    let containsForbiddenChars = forbiddenCharacters.some(
                        function(item){
                            return val.includes(item);
                        }
                    );

                    return !containsForbiddenChars;
                },
                message: 'Username should not contain invalid characters!'
            }
        },
        firstName: {
            type: String,
            minlength: 2,
            validate: {
                validator: function (val) {
                    'use strict';
                    let containsForbiddenChars = forbiddenCharacters.some(
                        function(item){
                            return val.includes(item);
                        }
                    );

                    return !containsForbiddenChars;
                },
                message: 'Name should not contain invalid characters!'
            }
        },
        lastName: {
            type: String,
            minlength: 2,
            validate: {
                validator: function (val) {
                    'use strict';
                    let containsForbiddenChars = forbiddenCharacters.some(
                        function(item){
                            return val.includes(item);
                        }
                    );

                    return !containsForbiddenChars;
                },
                message: 'Username should not contain invalid characters!'
            }
        },
        email: String, //TODO: Validate Email
        salt: String,
        hashPass: String,
        age: {
            type: Number,
            min: 16,
            max: 155
        },
        role: {
            type: String,
            default: 'user',
            validate: {
                validator: function (val) {
                    'use strict';
                    return userRoles.some(function(item){
                        return (item === val);
                    });
                },
                message: 'Invalid user role!'
            }
        }
    });

    userSchema.methods = {
        authenticate: function(password) {
            if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                return true;
            }
            else {
                return false;
            }
        },
        update: function(newProps){
            for(let prop in newProps){
                this[`${prop}`] = newProps[`${prop}`];
            }

            this.save();
            return this;
        }
    };


    var User = mongoose.model('User', userSchema);
};


