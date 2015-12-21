(function () {
    'use strict';

    function statistics($q, data, notifier) {

        // cash stats
        var statistics;

        function getStats() {

            notifier.success('Statistics service Ok');
            console.log('statistics-service Ok');

            if (statistics) {
               return $q.when(statistics);
            } else {
                return data.get('api/stats')
                    .then(function (stats) {
                        statistics = stats;
                        return stats;
                    });

            }

        }

        return {
            getStats: getStats
        }
    }

    angular.module('myApp.services')
    .factory('statistics', ['$q', 'data', 'notifier', statistics])
}());