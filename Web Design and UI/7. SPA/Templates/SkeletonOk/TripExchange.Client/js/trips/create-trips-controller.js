
(function () {
    'use strict';

    function CreateTripsController($location, cities, trips, notifier) {
        var vm = this;

        notifier.success('Create trips Ok');

        cities.getAll()
        .then(function (allCities) {
            vm.cities = allCities;

            console.log(allCities);
        });

        vm.createTrip = function (newTrip) {
            trips.createTrip(newTrip)
            .then(function (createdTrip) {
                $location.path('/trips/details/' + createdTrip.id);
            });
        }
    }

    angular.module('myApp.controllers')
        .controller('CreateTripsController', ['$location', 'cities', 'trips', 'notifier', CreateTripsController])
}());