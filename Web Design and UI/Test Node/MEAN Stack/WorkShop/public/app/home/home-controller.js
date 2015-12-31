(function () {
    'use strict';
    
    function HomeController() {
        var vm = this;
        debugger;
        vm.hello = 'Hello angular!';
    };
    
    
    
    angular.module('app.controllers')
    .controller('HomeController', [HomeController]);
}());