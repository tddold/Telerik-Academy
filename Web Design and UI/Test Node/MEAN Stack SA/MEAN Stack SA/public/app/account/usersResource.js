(function () {
    'use strict';
    
    function UsersResource($resource) {
        var UsersResource = $resource('api/users/:id', {_id: '@id'}, { update: { method: 'PUT', isArray: false }});

        UsersResource.prototype.isAdmin = function () {
            return this.rolse && this.rolse.indexOf('admin') > -1;
        };

        return UsersResource;
        
    }
    
    angular.module('myApp.services')
    .factory('UsersResource', ['$resource', UsersResource])
}());