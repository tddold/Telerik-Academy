(function () {
    'use strict';

    function allDrivers(notifier) {

        notifier.success('All drivers successful!');
        debugger;
        return {
            restict: 'A',
            templateUrl: 'views/directives/all-drivers-directive.html'
        }
    }



    angular.module('myApp.directives')
        .directive('allDrivers', ['notifier', allDrivers])
}());