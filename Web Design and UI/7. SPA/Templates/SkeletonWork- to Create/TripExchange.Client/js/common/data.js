(function () {
    'use strict';

    function data($http, $q, baseServiceUrl, notifier) {

        function get(url, queryParams) {
            var defered = $q.defer();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams })
            .then(function (response) {
                notifier.success('Get response');

                defered.resolve(response.data);
            }, function (err) {
                notifier.error(err);
                defered.reject(err);
            })

            return defered.promise;
        }

        function post(url, postData) {
            var defered = $q.defer();

            $http.post(baseServiceUrl + '/' + url, postData)
            .then(function (response) {
                notifier.success(response);

                defered.resolve(response.data);
            }, function (err) {
                notifier.error(err);
                defered.reject(err);
            })

            return defered.promise;
        }

        function put() {
            throw new Error('Not implemented!');
        }

        notifier.success('Data service Ok');
        console.log('data-service Ok');

        return {
            get: get,
            post: post,
            put: put
        }
    }



    angular.module('myApp.services')
  .factory('data', ['$http', '$q', 'baseServiceUrl', 'notifier', data])
}());