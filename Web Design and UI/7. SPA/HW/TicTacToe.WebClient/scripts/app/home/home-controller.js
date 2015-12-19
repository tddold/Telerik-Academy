(function () {
    'use strict';
    
    function HomeController() {
        var vm = this;

        vm.hi = 'Hi!!!';
    }

    angular.module('ticTacToeApp.controllers')
    .controller('HomeController', [HomeController])
}());