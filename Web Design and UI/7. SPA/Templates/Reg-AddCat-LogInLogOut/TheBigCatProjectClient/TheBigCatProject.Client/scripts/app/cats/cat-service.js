(function () {
    'use strict';

    function catsService($http, $q, baseUrl) {
        var defered = $q.defer();


        function addCat(cat) {
            $http.post(baseUrl + 'api/cats', cat)
            .then(function (response) {
                defered.resolve(response);
            }), function (err) {
                defered.reject(err);
            };

            return defered.promise;
        }

        return {
            addCat: addCat
        };
    };

    angular
        .module('catApp.services')
        .factory('cats', ['$http', '$q', 'baseUrl', catsService]);
}());