(function () {
    'use strict';

    function data($http, $q, authorization, baseServiceUrl, notifier) {

        function get(url, queryParams) {
            var defered = $q.defer();

            var authHeader = authorization.getAuthorizationHeader();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams, headers: authHeader })
            .then(function (response) {
                notifier.success('Get response');

                defered.resolve(response.data);
            }, function (err) {
                err = getErrorMessage(err);
                notifier.error(err);
                defered.reject(err);
            })

            return defered.promise;
        }

        function post(url, postData) {
            var defered = $q.defer();

            var authHeader = authorization.getAuthorizationHeader();

            $http.post(baseServiceUrl + '/' + url, postData, { headers: authHeader })
            .then(function (response) {
                notifier.success(response);

                defered.resolve(response.data);
            }, function (err) {
                err = getErrorMessage(err);
                notifier.error(err);
                defered.reject(err);
            })

            return defered.promise;
        }

        function put(url, putData) {
            var defered = $q.defer();
            debugger;
            var authHeader = authorization.getAuthorizationHeader();

            $http.post(baseServiceUrl + '/' + url + '/:' + putData.id, putData, { headers: authHeader })
            .then(function (response) {
                notifier.success(response);

                defered.resolve(response.data);
            }, function (err) {
                err = getErrorMessage(err);
                notifier.error(err);
                defered.reject(err);
            })

            return defered.promise;
        }

        notifier.success('Data service Ok');
        console.log('data-service Ok');

        function getErrorMessage(response) {
            var error = response.data.modelState;
            if (error && error[Object.keys(error)[0][0]]) {
                error = error[Object.keys(error)[0][0]]
            } else {
                error = response.data.message;
            }

            return error;
        }


        return {
            get: get,
            post: post,
            put: put
        }
    }



    angular.module('myApp.services')
  .factory('data', ['$http', '$q', 'authorization', 'baseServiceUrl', 'notifier', data])
}());