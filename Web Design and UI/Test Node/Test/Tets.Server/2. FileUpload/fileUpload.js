var forminable = require('formidable'),
    http = require('http'),
    util = require('util'),
    fs = require('fs-extra');

http.createServer(function (req, res) {
    
    // Display the file upload from.
    res.writeHead(200, { 'content-type': 'text/html' });
    res.end(
        '<form action="/upload" enctype="multipart/form-data" method="post"' +
        '<input type="text" name="title"><br>' +
        '<input type="file" name="upload" multiple="multiple"><br>' +
        '<input type="submit" value="upload">' +
        '</form>'
        );

}).listen(8080)