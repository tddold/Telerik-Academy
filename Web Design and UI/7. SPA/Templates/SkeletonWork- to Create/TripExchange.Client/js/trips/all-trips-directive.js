(function () {
    'use strict';

    function allTrips(notifier) {

        notifier.success('All trips successful!');
        return {
            restict: 'A',
            templateUrl: 'views/directives/all-trips-directive.html'
        }
    }



    angular.module('myApp.directives')
        .directive('allTrips', ['notifier', allTrips])
}());