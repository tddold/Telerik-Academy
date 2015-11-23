'use strict';

votterApp.controller('MainPageController',
    function MainPageController($scope, $rootScope, author, copyright, $location) {
        $scope.author = author;
        $scope.copyright = copyright;

        $scope.signOut = function () {
            $scope.isLoggedIn = false;
            $scope.path('/');
            localStorage.clear();
        };

        if (localStorage.getItem("LoggedIn")) {
            $scope.isLoggedIn = true;
            $scope.username = localStorage.getItem("username");
        }
    }
);