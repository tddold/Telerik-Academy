(function () {
    'use strict';

    function CoursesDetailsController(cashedCourses, $routeParams) {
        var vm = this;

        // vm.course = CourseResource.get({id: $routeParams.id});
        vm.course = cashedCourses.query().$promise.then(function (collection) {
            collection.forEach(function(course){
                if (course._id === $routeParams.id){
                    vm.course= course;
                }
            })
        })
    }

    angular.module('myApp.controllers')
        .controller('CoursesDetailsController', ['cashedCourses', '$routeParams', CoursesDetailsController])
}());