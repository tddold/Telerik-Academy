(function () {
    'use strict';

    function HomeController(statistics, trips, drivers, notifier) {
        var vm = this;

        statistics.getStats()
             .then(function (stats) {
                vm.stats = stats;
        });

        trips.gstPublicTrips()
            .then(function (publicTrips) {
                vm.trips = publicTrips;
                console.log(publicTrips);
            });

        drivers.gstPublicDrivers()
           .then(function (publicDrivers) {
               vm.publicDrivers = publicDrivers;
               console.log(publicDrivers);
           });

        notifier.success('HomeControler Ok');
        console.log('HomeControler Ok');
    }

    angular.module('myApp.controllers')
        .controller('HomeController', ['statistics', 'trips', 'drivers', 'notifier', HomeController]);
}());