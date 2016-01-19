(function () {
    'use strict';

    function cashedCourses(CourseResource) {
        var vm = this;
        var cashedCourses;

        return{
            query: function () {
                if (!cashedCourses){
                   cashedCourses = CourseResource.query();
                }

                return cashedCourses;
            }
        }
    }

    angular.module('myApp.controllers')
        .factory('cashedCourses', ['CourseResource', cashedCourses])
}());