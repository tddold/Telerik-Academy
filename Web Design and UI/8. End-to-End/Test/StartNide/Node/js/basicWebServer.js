var http = require ('http');

var port = 1234;

http.createServer(function (request, response) {
    response.writeHead(200, {
        'Content-Type': 'application/json'
    });

    response.write(JSON.stringify(http));
    response.end();
})
.listen(port);

console.log('Server is running on port: ' + port)