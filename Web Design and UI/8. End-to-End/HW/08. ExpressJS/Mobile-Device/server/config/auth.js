'use strict';

let passport = require('passport');

module.exports = {
    login: function (req, res, next) {
        let auth = passport.authenticate('local', function (err, user) {
            if (err) return next(err);
            if (!user) {
                req.session.error = 'Invalid user name or password!';
                res.redirect('/login');
                // res.render('shared/error', {error:'Invalid user name or password!'});
            }

            req.logIn(user, function (err) {
                if (err) return next(err);
                res.redirect('/');
            })
        });

        auth(req, res, next);
    },
    logout: function (req, res) {
        req.logout();
        res.redirect('/');
    },
    isAuthenticated: function (req, res, next) {
        if (!req.isAuthenticated()) {
            res.redirect('/login');
        }
        else {
            next();
        }
    }
};