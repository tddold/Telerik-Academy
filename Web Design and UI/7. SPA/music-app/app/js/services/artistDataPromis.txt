'use strict';

musicApp.factory('artistData', function ($http, $q, $log) {

    return {
        getArtist: function (id) {
            var defer = $q.defer();

            $http({ method: 'GET', url: 'data/artist/1' + id })
            .success(function (data, status, header, config) {
                defer.resolve(data);
            })
            .error(function (data, status, header, config) {
               defer.reject(data);
            });

            return defer.promise;
        }
    }
});