var forminable = require('formidable'),
    http = require('http'),
    util = require('util'),
    fs = require('fs')
port = 8080;

http.createServer(function (req, res) {

    // Display the file upload from.
    res.writeHead(200, {
        'content-type': 'text/html'
    });

    if (req.url === '/' && req.method.toLowerCase() == 'get') {
        res.end(generateFormHtml())
    }

    if (req.url === '/upload' && req.method.toLowerCase() == 'post') {
        parseFormData(req, res);
        return;
    }

    if (res.url.indexOf('/image') === 0) {
        var imageId = __dirname + req.url;

        res.writeHead(200, {
            'Content-Type': 'text/html'
        });

        fs.readFile(imageId, function (err, data) {
            if (err) {
                console.log('Cannot read image...');
                return;
            }

            res.write('<html><body><img src="data:image/jpeg;base64,"');
            res.write(new Buffer(dara).toString('base64'));
            res.end('"/></body></html>');
        });

        return;
    }

    function parseFormData(req, res, form) {
        var form = new forminable.IncomingForm();
        form.parse(req, function (err, fields, files) {
            var filePath = files.upload.path;
            saveFile(filePath, res);
        });
    }

    function saveFile(filePath, res) {
        fs.readFile(filePath, function (err, original_data) {
            var id = uuid.v1();
            var base64Image = original_data.toString('base64');
            var decodetImage = new Buffer(base64Image, 'base64');
            fs.writeFile('Images/' + id + imageExt, decodedImage, function (err) { });
            res.write('You can access image at: loclhost:' + port + '/images' + id + imageExt);
            res.end();
        })
    }

    res.end();

}).listen(port)

console.log('Server is running on port: ' + port)

function generateFormHtml() {
    return '<form action="/upload" enctype="multipart/form-data" method="post"' +
        '<input type="text" name="title"><br>' +
        '<input type="file" name="upload" multiple="multiple"><br><br>' +
        '<input type="submit" value="upload">' +
        '</form>'
}