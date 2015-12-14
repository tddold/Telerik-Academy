(function () {
    'use strict';

    function RegisterController(auth) {
        var vm = this;

        console.log(auth);

        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                .then(function () {
                    console.log('Works!');
                });
            }
        };
    }

    angular.module('catApp.controller')
    .controller('RegisterController', ['auth', RegisterController]);
}());