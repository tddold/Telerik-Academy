(function () {
        'use strict';
        
        function config($routeProvider, $locationProvider) {
            var CONTROLLER_VIEW_MODEL_NAME = 'vm';
            
            $locationProvider.html5Mode(true);
            
            $routeProvider
            .when('/', {
                templateUrl: 'partials/home/home.ht,l',
                controler: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .otherwise({ redirectTo: '/' });
        };
        
        angular.module('app.services', []);
        angular.module('app.derictives', []);
        angular.module('app.controllers', ['app.services']);

        angular.module('app', ['ngResource', 'ngRoute', 'ngCookies', 'app.controllers', 'app.derictives'])
        .config(['$routeProvider', '$locationProvider', config])
        .constant('baseUrl', 'http://localhost:3030/');
    }());