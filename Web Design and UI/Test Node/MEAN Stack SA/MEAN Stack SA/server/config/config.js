var path = require('path'),
    rootPath = path.normalize(__dirname + '/../../')

module.exports = {
    
    development: {
        rootPath : rootPath,
        db: 'mongodb://localhost/means',
        port : process.env.PORT || 3030
    },
    production: {
        rootPath : rootPath,
        db: 'mongodb://admin:means1234@ds037015.mongolab.com:37015/means',
        port : process.env.PORT || 3030
    }
};
