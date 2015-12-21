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
        .when('/users', {
            templateUrl: 'partials/users.html',
            controller: 'UsersController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME
        })
        .when('/scores', {
            templateUrl: 'partials/scores.html',
            controller: 'ScoresController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME
        })
        .when('/identity/register', {
            templateUrl: 'partials/identity/register.html',
            controller: 'RegisterController',
            controllerAs: CONTROLLER_VIEW_MODEL_NAME
        })
        .otherwise({ redirect: '/' });
    }

    angular.module('ticTacToeApp.services', []);
    angular.module('ticTacToeApp.controllers', ['ticTacToeApp.services']);

    angular.module('ticTacToeApp', ['ngRoute', 'ngCookies', 'ticTacToeApp.controllers'])
    .config(['$routeProvider', '$locationProvider', config])
    .constant('baseUrl', 'http://localhost:33257/');
}());