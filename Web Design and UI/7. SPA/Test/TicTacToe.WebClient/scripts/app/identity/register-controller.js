(function () {
    'use strict';

    function RegisterController(auth) {
        var vm = this;

        console.log(auth);
        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                .then(function () {
                    console.log('Register user');
                });
            }

        }

    }

    angular.module('ticTacToeApp.controllers')
        .controller('RegisterController', ['auth', RegisterController])
}());