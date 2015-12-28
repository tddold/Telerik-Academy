var http = require('http');
var fs = require('fs');

var port = 9876;

http.createServer(function (request, response) {
    fs.readFile('index.html', function (err, data) {
        if (err) {
            console.log(err);
        }
        
        response.writeHeader(200, {
            'Content-Type' : 'text/html'
        })
        response.write(data);
        response.end();
    });
})
    .listen(port);

console.log('Server running on port ' + port);