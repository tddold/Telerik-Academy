(function () {
    'use strict';

    function RegisterController(auth) {
        var vm = this;

        console.log(auth);

        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {
                console.log('...Registering user...');
                auth.register(user)
                    .then(function () {
                        console.log('WORK')
                });
            }
        };
    }

    angular.module('catApp.controllers')
        .controller('RegisterController', ['auth', RegisterController])
}());