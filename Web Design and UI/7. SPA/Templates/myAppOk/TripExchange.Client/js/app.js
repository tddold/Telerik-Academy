(function () {
    'use strict';

    function config($routeProvider) {
        var CONTROLLER_AS_VIEW_MODEL = 'vm';
        var PARTIALS_PREFIX = 'views/partials/';


        $routeProvider
            .when('/', {
                templateUrl: PARTIALS_PREFIX + 'home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
             .when('/unauthorized', {
                 template: '<h1 class="text-center">YOU ARE NOT AUTHORIZED!</h1>'
             })
            .when('/trips', {
                templateUrl: PARTIALS_PREFIX + 'trips/all-trips.html',
                controller: 'TripsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/trips/create', {
                templateUrl: PARTIALS_PREFIX + 'trips/create-trips.html',
                controller: 'CreateTripsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
             .when('/trips/details/:id/:name/:from/:to/:date/:seats/:pass', {
                 templateUrl: PARTIALS_PREFIX + 'trips/trips-details.html',
                 controller: 'TripsDetailsController',
                 controllerAs: CONTROLLER_AS_VIEW_MODEL
             })
            .when('/register', {
                templateUrl: PARTIALS_PREFIX + 'identity/register.html',
                controller: 'SignUpCtrl'
            })
            .otherwise({ redirectTo: '/' });
    }

    angular.module('myApp.services', []);
    angular.module('myApp.directives', []);
    angular.module('myApp.filters', []);
    angular.module('myApp.controllers', ['myApp.services']);
    angular.module('myApp', ['ngRoute', 'ngCookies', 'kendo.directives', 'myApp.controllers', 'myApp.directives', 'myApp.filters']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa2014.bgcoder.com');
}());