'use strict';

var votterApp = angular.module('votterApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'templates/home.html'
            })
            .when('/signin', {
                templateUrl: 'templates/signin.html'
            })
            .when('/signup', {
                templateUrl: 'templates/signup.html'
            })
            .when('/vote-for-persons', {
                templateUrl: 'templates/vote-for-persons.html'
            })
            .when('/upload-picture', {
                templateUrl: 'templates/upload-picture.html'
            })
            .otherwise({ redirectTo: '/' });
    })
    .constant('author', 'Papaya Team')
    .constant('copyright', 'Telerik Academy');