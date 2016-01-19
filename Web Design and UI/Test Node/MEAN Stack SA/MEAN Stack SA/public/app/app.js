(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {
        var CONTROLLER_VEW_MODEL_NAME = 'vm';

        $locationProvider.html5Mode(true);

        var routeUserChecks = {
            adminRole: {
                authenticate: function (auth) {
                    return auth.isAuthorizedForRole('admin');
                }
            },
            authenticated: {
                authenticate: function (auth) {
                    return auth.isAuthenticated();
                }
            }
        };

        $routeProvider
            .when('/', {
                templateUrl: '/partials/home/home',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME
            })
            .when('/courses', {
                templateUrl: '/partials/courses/courses-list',
                controller: 'CoursesListController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME
            })
            .when('/courses/:id', {
                templateUrl: '/partials/courses/course-details',
                controller: 'CoursesDetailsController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME
            })
            .when('/signup', {
                templateUrl: '/partials/account/signup',
                controller: 'SignUpController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME
            })
            .when('/profile', {
                templateUrl: '/partials/account/profile',
                controller: 'ProfileController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME,
                resolve: routeUserChecks.authenticated
            })
            .when('/admin/users', {
                templateUrl: '/partials/admin/user-list',
                controller: 'UserListController',
                controllerAs: CONTROLLER_VEW_MODEL_NAME,
                resolve: routeUserChecks.adminRole
            })
            .otherwise({redirectTo: '/'});
    };

    function run($rootScope, $location) {
        $rootScope.$on('$routeChangeError', function (event, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/');
            }
        })
    }

    angular.module('myApp.services', []);
    angular.module('myApp.derivtives', []);
    angular.module('myApp.controllers', ['myApp.services']);

    angular.module('myApp', ['ngResource', 'ngRoute', 'ngCookies',
            'myApp.controllers', 'myApp.derivtives'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$rootScope', '$location', run])
        .value('toastr', toastr)
        .constant('baseUrl', 'http://localhost:3030')
}());