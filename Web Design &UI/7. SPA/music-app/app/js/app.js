'use strict';

var musicApp = angular
    .module('musicApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider) {

        $routeProvider
            .when('/', {
                templateUrl: '/templates/list-artists.html'
            })
            .when('/add-artist', {
                templateUrl: '/templates/add-artist.html'
            })
            .when('/artist-details/:id', {
                templateUrl: '/templates/artist-details.html'
            })
            .otherwise({ redirectTo: '/' });

    })
    .constant('author', 'Ivailo Kenov');





//.value('toastr', toastr)
//.constant('baseServiceUrl', 'http://localhost:1234')