(function () {
    'use strict';

    function drivers(data, notifier) {
        var DRIVERS_URL = 'api/drivers';

        function gstPublicDrivers() {

            notifier.success('Get drivers Ok');
            return data.get(DRIVERS_URL);
        }

        function filterDrivers(filters) {

            notifier.success('Get filter drivers Ok');
            return data.get(DRIVERS_URL, filters);
        }

        function filterDriversByName(filters) {

            notifier.success('Get filter driversByName Ok');
            return data.get(DRIVERS_URL, filters);
        }

        notifier.success('Drivers service Ok');
        console.log('drivers-service Ok');
        return {
            gstPublicDrivers: gstPublicDrivers,
            filterDrivers: filterDrivers,
            filterDriversByName: filterDriversByName
        }
    }

    angular.module('myApp.services')
        .factory('drivers', ['data', 'notifier', drivers])
}());