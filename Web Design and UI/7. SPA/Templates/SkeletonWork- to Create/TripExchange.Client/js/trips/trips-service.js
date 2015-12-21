(function () {
    'use strict';

    function trips(data, notifier) {

        function gstPublicTrips() {

            notifier.success('Get trips Ok');
            return data.get('api/trips');
        }


        notifier.success('Trips service Ok');
        console.log('trip-service Ok');
        return {
            gstPublicTrips: gstPublicTrips
        }
    }

    angular.module('myApp.services')
        .factory('trips', ['data', 'notifier', trips])
}());