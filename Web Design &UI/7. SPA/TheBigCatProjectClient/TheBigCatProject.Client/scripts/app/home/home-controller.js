(function () {
    'use strict';

    function HomeController() {
        var vm = this;

        vm.hi = 'Hi';
    }

    angular.module('catApp.controller')
    .controller('HomeController', [HomeController]);
}());