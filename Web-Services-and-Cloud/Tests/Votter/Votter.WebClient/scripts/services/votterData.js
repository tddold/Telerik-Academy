'use strict';

votterApp.factory('votterData', function ($resource, $q, $http) {
    var url = 'http://ratemygirlfriendservices.apphb.com/';

    return {
        register: function (email, password) {
            var deferred = $q.defer();
            $http.post(url + 'api/Account/Register', {
                Email: email,
                Password: password,
                ConfirmPassword: password,
            },
            {
                transformRequest: function (obj) {
                    var str = [];
                    for (var p in obj)
                        str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                    return str.join("&");
                },
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }
            })
            .success(function (data, status, headers, config) {
                deferred.resolve(data);
            })

            return deferred.promise;
        },
        login: function (email, password) {
            var deferred = $q.defer();

            $http.post(url + 'Token', {
                    username: email,
                    password: password,
                    grant_type: "password"
                },
                {
                transformRequest: function (obj) {
                    var str = [];
                    for (var p in obj)
                        str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                    return str.join("&");
                },
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }
            })
            .success(function (data, status, headers, config) {
                deferred.resolve(data);
            })

            return deferred.promise;
        }
    }
});
