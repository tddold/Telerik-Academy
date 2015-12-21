(function () {
    'use strict';

    function TripsController(trips, identity) {
        var vm = this;
        vm.identity = identity;

        trips.gstPublicTrips()
        .then(function (publicTrips) {
            vm.trips = publicTrips;
        })
    }

    angular.module('myApp.controllers')
        .controller('TripsController', ['trips', 'identity', TripsController])
}());