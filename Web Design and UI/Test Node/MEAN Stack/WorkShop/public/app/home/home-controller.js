(function () {
    'use strict';
    
    function HomeController() {
        var vm = this;
        
        vm.hello = 'Hello angular!';
    };
    
    
    
    angular.module('app.controllers')
    .controller('HomeController', [HomeController]);
}());