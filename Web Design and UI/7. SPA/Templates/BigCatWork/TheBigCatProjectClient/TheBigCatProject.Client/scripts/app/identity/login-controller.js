(function () {
    'use strict';

    function LoginController($location, auth) {
        var vm = this;

        vm.login = function (user, loginForm) {
            if (loginForm.$valid) {
                console.log('...Login user...');
                auth.login(user)
                    .then(function () {
                        console.log('...User logged...');
                        $location.path('/');
                    });
            }
        }
    }

    angular.module('catApp.controllers')
        .controller('LoginController', ['$location', 'auth', LoginController]);
}());