(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {
        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        $locationProvider.html5Mode(true);

        $routeProvider
        .when('/', {
            templateUrl: 'partials/home/home.html',
            controller: 'HomeController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME
        })
        .when('/identity/register', {
            templateUrl: 'partials/identity/register.html',
            conntroller: 'RegisterController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME

        })
        .otherwise({ redirectTo: '/' })
    }


    angular.module('catApp.controller', [])
    angular.module('catApp.services', [])

    angular.module('catApp', ['ngRoute', 'catApp.controller'])
    .config(['$routeProvider', '$locationProvider', config]);
}());