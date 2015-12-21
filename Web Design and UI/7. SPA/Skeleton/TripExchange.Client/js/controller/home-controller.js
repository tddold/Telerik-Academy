(function () {
    'use strict';

    function HomeController($scope,notifier) {

        notifier.success('psho');
        console.log('wass here');
        //statistics.getStats()
        //.then(function (stats) {
        //    vm.stats = stats;
        //});

    }

    angular.module('myApp.controllers')
    .controller('HomeController', ['$scope', 'notifier',HomeController])
}());