(function () {
    'use strict';
    
    function config($routeProvider, $locationProvider) {
        var CONTROLLER_VEW_MODEL_NAME = 'vm';
        
        $locationProvider.html5Mode(true);
        
        $routeProvider
            .when('/', {
            templateUrl: '/partials/home/home',
            controller: 'HomeController',
            controllerAs: CONTROLLER_VEW_MODEL_NAME
        })
            .otherwise({ redirectTo: '/' });
    };
    
    angular.module('myApp.services', []);
    angular.module('myApp.derivtives', []);
    angular.module('myApp.controllers', ['myApp.services']);
    
    angular.module('myApp', ['ngResource', 'ngRoute', 'ngCookies',
        'myApp.controllers', 'myApp.derivtives'])
        .config(['$routeProvider', '$locationProvider', config])
        .constant('baseUrl', 'http://localhost:3030')
}());