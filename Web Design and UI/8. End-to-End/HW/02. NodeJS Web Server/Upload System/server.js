(function () {
    'use strict';

    var formidable = require('formidable'),
        http = require('http'),
        uuid = require('uuid'),
        url = require('url'),
        fs = require('fs-extra'),
        port = 3030,
        filePath;

    http.createServer(function (req, res) {
        res.writeHead(200,{
            'content-type': 'text/html'
        });

        if (req.url === '/' && req.method.toLowerCase() == 'get'){
            res.end(generateFormHtml());
        }

        if (req.url == '/upload' && req.method.toLowerCase() == 'post'){
            parseFormData(req, res);
            console.log('Upload success!');
            return;
        }

        if(req.url.indexOf('/files') === 0){
           var fileId = __dirname + req.url;

            res.writeHead(200, {
                'Content-Type': 'text/html'
            });

            fs.readeFile(fileId, function (error, data) {
                if (error){
                    console.log('Cannot read file...');
                    return;
                }

                res.write(generateFormHtmlSuccessful());
                res.end();
            });

            return;
        }

        function parseFormData(req,res,form){
            var form = new formidable.IncomingForm();
            form.keepExtensions = true;
            var id = uuid.v1();
            form.parse(req, function (err, fields, files) {
                res.writeHead(200, {
                    'content-type': 'text/html'
                });

                res.write(generateHtmlUploadSuccessful());
                res.end();
            });

            form.on('progress', function(bytesReceived, bytesExpected) {
                var percent_complete = (bytesReceived / bytesExpected) * 100;
                console.log(percent_complete.toFixed(2));
            });

            form.on('end', function(fields, files) {
                var temp_path = this.openedFiles[0].path;
                var fileName = this.openedFiles[0].name;
                var location = 'files/' + id;
                filePath = location + fileName;

                fs.copy(temp_path, location + fileName, function(err) {
                    if (err) {
                        console.error(err);
                    } else {
                        console.log("success!");
                    }
                });
            });

            return;
        }

        if (req.url === '/download') {
            fs.readFile(filePath, 'utf8', function(err, fileText) {
                    if (err) {
                        console.log('File cannot be read: ' + error);
                        return;
                    }
                    var fileName = getFileName(filePath)
                    fs.writeFile('downloads/' + fileName, fileText, function(err) {
                        if (err) {
                            console.log('File cannot be write: ' + err);
                        } else {
                            console.log('File downloaded')
                        }
                    });
            });
        }

        res.end(generateHtmlDownloadSuccessful());
    }).listen(port);

    console.log('Server running on port ' + port);

    function getFileName(filePath){
        return filePath.substring(filePath.lastIndexOf('/') + 1);
    }

    function getExtensions(fileName){
        return fileName.substring(fileName.lastIndexOf('.'));
    }

    function generateHtmlDownloadSuccessful(){
        return '<h4>Download finished</h4>' +
            '<div>' +
                '<a href="/"><input type="submit" value="Back"/></a>' +
            '</div>'
    }

    function generateHtmlUploadSuccessful(){
        return  '<h4>Upload finished</h4>' +
                '<div>' +
                    '<a href="/"><input type="submit" value="Back"/></a>' +
                '</div>' +
                '<br>' +
                '<div>' +
                '<h4>Download a file:</h4>' +
                    '<input type="file" name="upload" accept="files/*"/>' +
                '</div>' +
                '<br>' +
                '<div>' +
                    '<a href="/download">' +
                        '<input type="submit" value="Download"/>' +
                    '</a>' +
                '</div>'
    }

    function generateFormHtml(){
        return '<h4>Upload file</h4>' +
            '<form action="/upload" enctype="multipart/form-data" method="post">' +
                '<input type="file" name="upload" accept="files/*"><br>' +
                '<br>'+
                '<input type="submit" value="Upload">'+
            '</form>'
    }
}());