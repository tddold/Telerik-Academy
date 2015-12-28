var http = require('http');

var port = 1234;

http.createServer(function (req, res) {
    res.writeHead(200, {
        'Content-Type': 'application/json'
    });

    var cache = [];
    var dump = function (key, value) {
        if (typeof value === 'object' && value != null) {
            if (cache.indexOf(value) != -1) {
                return;
            }

            cache.push(value);
        }

        return value;
    }

    res.write(JSON.stringify(req, dump));
    res.end();
})
.listen(port);

console.log('Server is running on port ' + 1234);