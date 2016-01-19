﻿(function () {
    'use strict';
    
    function auth($q, $http, identity, UsersResource) {
        return {
            signup: function (user) {
                var deferred = $q.defer();

                var user = new UsersResource(user);
                user.$save().then(function () {
                    identity.currentUser=user;
                    deferred.resolve();
                }, function (response) {
                    deferred.reject(response)
                });

                return deferred.promise;
            },
            update: function (user) {
                var deferred = $q.defer();

                var updatedUser = new UsersResource(user);
                updatedUser._id = identity.currentUser._id;
                updatedUser.$update().then(function () {
                    identity.currentUser.firstName = updatedUser.firstName;
                    identity.currentUser.lastName = updatedUser.lastName;
                    deferred.resolve();
                }, function (response) {
                    deferred.reject(response)
                });

                return deferred.promise;
            },
            login: function (user) {
                var deferred = $q.defer();
                
                $http.post('/login', user).success(function (response) {
                    if (response.success) {
                        var user = new UsersResource();
                        angular.extend(user, response.user);

                        identity.currentUser = user;
                        deferred.resolve(true);
                    } else {
                        deferred.resolve(false);
                    }
                });
                
                return deferred.promise;
            },
            logout: function (user) {
                var deferred = $q.defer();
                
                $http.post('/logout').success(function () {
                    identity.currentUser = undefined;
                    deferred.resolve();
                });
                
                return deferred.promise;
            },
            isAuthenticated: function (role) {
                if (identity.isAuthenticated(role)){
                    return true;
                } else  {
                    return $q.reject('not authorized');
                }
            },
            isAuthorizedForRole: function (role) {
                if (identity.isAuthorisedForRole(role)) {
                    return true;
                } else {
                   return $q.reject('not authorized');
                }
            }
        }
    }
    
    angular.module('myApp.services')
    .factory('auth', ['$q', '$http', 'identity', 'UsersResource', auth])
}());