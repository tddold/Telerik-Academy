(function () {
    'use strict';

    function statistics($http, $q, baseServiceUrl) {

        function getStats() {
            var defered = $q.defer();

            debugger;
            $http.get(baseServiceUrl + '/api/stats')
            .then(function (response) {
                defered.resolve(response.data);
            });

            return defered.promise;
        }

        return {
            getStats: getStats
        }
    }

    angular.module('myApp.services')
    .factory('statistics', ['$http', '$q', 'baseServiceUrl', statistics])
}());