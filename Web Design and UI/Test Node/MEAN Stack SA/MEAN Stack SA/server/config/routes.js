module.exports = function (app) {
    app.get('/partials/:partialArea/:partialName', function (req, res) {
        res.render('../../public/app/' + req.params.partialArea + '/' + req.params.partialName);
    });
    
    app.get('*', function (req, res) {
        res.render('index');
    });
};
