(function () {
    'use strict';

    function drivers(data, notifier) {

        function gstPublicDrivers() {

            notifier.success('Get drivers Ok');
            return data.get('api/drivers');
        }


        notifier.success('Drivers service Ok');
        console.log('drivers-service Ok');
        return {
            gstPublicDrivers: gstPublicDrivers
        }
    }

    angular.module('myApp.services')
        .factory('drivers', ['data', 'notifier', drivers])
}());