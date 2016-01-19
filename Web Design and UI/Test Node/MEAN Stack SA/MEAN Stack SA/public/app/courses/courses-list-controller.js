(function () {
    'use strict';

    function CoursesListController(cashedCourses) {
        var vm = this;

        vm.courses = cashedCourses.query();
    }

    angular.module('myApp.controllers')
        .controller('CoursesListController', ['cashedCourses', CoursesListController])
}());