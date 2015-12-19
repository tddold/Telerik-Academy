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
            controller: 'RegisterController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME

        }).when('/identity/login', {
            templateUrl: 'partials/identity/login.html',
            controller: 'LoginController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME

        })
        .otherwise({ redirect: '/' });
    }

    function run($http, $cookies, auth) {
        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity();
        }
    };

    angular.module('catApp.services', [])
    angular.module('catApp.controllers', ['catApp.services'])

    angular.module('catApp', ['ngRoute', 'ngCookies', 'catApp.controllers'])
    .config(['$routeProvider', '$locationProvider', config])
        .run(['$http', '$cookies', 'auth', run])
   .constant('baseUrl', 'http://localhost:59613/');
}());