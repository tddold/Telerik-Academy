
(function () {
    'use strict';

    function CreateTripsController(cities, notifier) {
        var vm = this;

        notifier.success('Create trips Ok');

        cities.getAll()
        .then(function (allCities) {
            vm.cities = allCities;

            console.log(allCities);
        });
    }

    angular.module('myApp.controllers')
        .controller('CreateTripsController', ['cities', 'notifier', CreateTripsController])
}());