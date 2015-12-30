//var mongodb = require('mongodb');

//var server = new mongodb.Server('localhost', 27017);
//var mongoClient = new mongodb.MongoClient(server);

//mongoClient.open(function (Error, mongoClient) {
//    var db = mongoClient.db('student');
//    var courses = db.collection('courses');

//    courses.insert({ name: 'NodeJS', lectures: 10 },
//         function (err, courses) {
//             if (err) {
//            console.log(err);
//             }

//        console.log(courses);
//    });
//});

/*
* This example uses the node MongoDB module to connect to the local
* mongodb database on this virtual machine
*
* More here: http://mongodb.github.io/node-mongodb-native/markdown-docs/collections.html
*/

//require node modules (see package.json)
var mongodb = require('mongodb'),
    MongoClient = mongodb.MongoClient,
    format = require('util').format,
    url = 'mongodb://127.0.0.1:27017/test';


//connect away
MongoClient.connect(url, function (err, db) {
    if (err) {
        throw err;
    }
    console.log("Connected to Database");
    
    //create collection
    db.createCollection("testCollection", function (err, collection) {
        if (err) {
            throw err;
        }
        
        console.log("Created testCollection");

        collection.insert({
            name: 'AngularJS',
            lectures:10
        })

        collection
        .find({ $or: [{ name: 'AngularJS' }, { name: 'NodeJS' }] })
        .toArray(function (err, result) {
            console.log(result);
        })
    });
});

