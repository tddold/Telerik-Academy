(function () {
    'use strict';
    
    function HomeController(cashedCourses) {
        var vm = this;

        vm.courses = cashedCourses.query();
    }
    
    angular.module('myApp.controllers')
    .controller('HomeController', ['cashedCourses', HomeController])
}());