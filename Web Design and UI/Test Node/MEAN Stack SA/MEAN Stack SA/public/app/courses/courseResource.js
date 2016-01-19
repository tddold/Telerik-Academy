(function () {
    'use strict';

    function CourseResource($resource) {
        var CourseResource = $resource('api/courses/:id', {id: '@id'}, { update: { method: 'PUT', isArray: false }});


        return CourseResource;
    }

    angular.module('myApp.services')
        .factory('CourseResource', ['$resource', CourseResource])
}());