(function () {
    'use strict';

    function RegisterController() {
        var vm = this;

        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {

            }
        };
    }

    angular.module('catApp.controller')
    .controller('RegisterController', [RegisterController]);
}());