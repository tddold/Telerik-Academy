var mongoose = require('mongoose'),
    encription = require('../utilities/encryption'),
    userSchema,
    User;


userSchema = mongoose.Schema({
    username: {type: String, require: '{PATH} is require', unique: true},
    firstName: {type: String, require: '{PATH} is require'},
    lastName: {type: String, require: '{PATH} is require'},
    salt: String,
    hashPass: String,
    rolse: [String]
});

userSchema.method({
    authenticate: function (password) {
        if (encription.generateHashedPassword(this.salt, password) === this.hashPass) {
            return true;
        } else {
            return false;
        }
    }
});

User = mongoose.model('User', userSchema);

module.exports.seedInitialUsers = function () {
    User.find({}).exec(function (err, collection) {
        if (err) {
            console.log('Cannot find users' + err);
            return;
        }


        if (collection.length === 0) {
            var salt,
                hashedPwd;

            salt = encription.generateSalt();
            hashedPwd = encription.generateHashedPassword(salt, 'Pesho');
            User.create({
                username: 'Pesho',
                firstName: 'Pesho',
                lastName: 'Peshev',
                salt: salt,
                hashPass: hashedPwd,
                rolse: ['admin']
            });

            salt = encription.generateSalt();
            hashedPwd = encription.generateHashedPassword(salt, 'Ivan');
            User.create({
                username: 'Ivan',
                firstName: 'Ivan',
                lastName: 'Ivanov',
                salt: salt,
                hashPass: hashedPwd,
                rolse: ['standard']
            });

            salt = encription.generateSalt();
            hashedPwd = encription.generateHashedPassword(salt, 'Gosho');
            User.create({username: 'Gosho', firstName: 'Gosho', lastName: 'Goshev', salt: salt, hashPass: hashedPwd});
            console.log('Users added to database...');
        }
    });
};