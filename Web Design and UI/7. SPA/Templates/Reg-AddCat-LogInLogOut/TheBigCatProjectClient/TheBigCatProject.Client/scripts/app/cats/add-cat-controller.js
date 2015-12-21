(function () {
    'use strict';

    function AddCatController($location,cats) {
        var vm = this;

        vm.addCat = function (cat, catForm) {
            if (catForm.$valid) {
                console.log('...Add cat...');
                cats.addCat(cat)
                .then(function () {
                    console.log('...Cat added...');
                    // $location.path('/identity/login');
                });
            }
        }
    }

    angular.module('catApp.controllers')
        .controller('AddCatController', ['$location', 'cats', AddCatController]);
}());