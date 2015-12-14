'use strict'

musicApp.controller('PageController',
    function PageController($scope, author) {
        $scope.author =author;
        $scope.date = {
            year: 2015,
            month: 12,
            day:7
        };
    }
 );