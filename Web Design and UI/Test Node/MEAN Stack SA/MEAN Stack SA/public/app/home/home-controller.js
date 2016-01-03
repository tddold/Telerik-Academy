(function () {
    'use strict';
    
    function HomeController() {
        var vm = this;
  
        vm.hello = 'Hello Angular!';
    };
    


    angular.module('myApp.controllers')
    .controller('HomeController', [HomeController])
}());