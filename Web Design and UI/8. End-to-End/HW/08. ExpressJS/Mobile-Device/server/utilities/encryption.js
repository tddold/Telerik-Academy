'use strict';

let crypto = require('crypto');

module.exports = {
    generateSalt: function () {
        return crypto.randomBytes(128).toString('base64');
    },
    generateHashedPassword: function (salt, pwd) {
        let hmac = crypto.createHmac('sha1', salt);
        return hmac.update(pwd).digest('hex');
    },
    encrypt: function(text, key) {
        let cipher = crypto.createCipher('aes256', key);
        let encryptedData = cipher.update(text, "binary", "hex");
        return (encryptedData + cipher.final("hex"));
    },
    decrypt: function(cipher, key) {
        let decipher = crypto.createDecipher("aes256", key);
        let decryptedData = decipher.update(cipher, "hex", "binary");
        return (decryptedData + decipher.final("binary"));
    }
};