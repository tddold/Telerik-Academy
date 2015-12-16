(function () {
    'use strict';

    function HomeController() {
        var vm = this;

        vm.hi = 'Hi';
    }

    angular.module('catApp.controllers')
    .controller('HomeController', [HomeController]);
}());