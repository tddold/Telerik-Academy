(function () {
    'use strict';

    function trips(data, notifier) {
        var TRIPS_URL = 'api/trips';

        function gstPublicTrips() {

            notifier.success('Get trips Ok');
            return data.get(TRIPS_URL);
        }

        function filterTrips(filters) {

            notifier.success('Get filter trips Ok');
            return data.get(TRIPS_URL, filters);
        }

        function createTrip(trip) {
            return data.post(TRIPS_URL, trip);
        }

        notifier.success('Trips service Ok');
        console.log('trip-service Ok');
        return {
            gstPublicTrips: gstPublicTrips,
            createTrip: createTrip,
            filterTrips: filterTrips
        }
    }

    angular.module('myApp.services')
        .factory('trips', ['data', 'notifier', trips])
}());