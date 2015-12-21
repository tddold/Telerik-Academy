(function () {
    'use strict';

    function TripsDetailsController($routeParams) {
        debugger;
        var vm = this;
        vm.id = $routeParams.id; // $routeParams['id']
        vm.name = $routeParams.name;
    }

    angular.module('myApp.controllers')
        .controller('TripsDetailsController', ['$routeParams', TripsDetailsController]);
}());