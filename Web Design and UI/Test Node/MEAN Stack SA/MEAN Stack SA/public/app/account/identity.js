(function () {
    'use strict';
    
    function identity($window, UsersResource) {
        var currentUser,
            user;
        
        if ($window.bootstrappedUserObject) {
            user = new UsersResource();
            angular.extend($window.bootstrappedUserObject, user);
        }

        return {
            currentUser: user,
            isAuthenticated: function () {
                return !!this.currentUser;
            },
            isAuthorisedForRole: function (role) {
                return !!this.currentUser && this.currentUser.rolse.indexOf(role) > -1;
            }
        }
    }
    
    angular.module('myApp.services')
    .factory('identity', ['$window', 'UsersResource', identity])
}());