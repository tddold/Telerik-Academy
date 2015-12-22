(function () {
    'use strict';

    function TripsDetailsController($routeParams, trips) {
        var vm = this;

        console.log($routeParams);
        vm.id = $routeParams.id; // $routeParams['id']
        vm.name = $routeParams.name;
        vm.from = $routeParams.from;
        vm.to = $routeParams.to;
        vm.date = $routeParams.date;
        vm.seats = $routeParams.seats;
        vm.passengers = $routeParams.pass;
       // vm.trip = $routeParams;
       
        vm.joinTrips = function (id) {
            trips.join(id)
                .then(function (joinTrip) {
                    notifier.success('Successfully joined the trip');
                    $location.path('/trips' + joinTrip.id);
                });
        }
    }

    angular.module('myApp.controllers')
        .controller('TripsDetailsController', ['$routeParams', 'trips', TripsDetailsController]);

}());