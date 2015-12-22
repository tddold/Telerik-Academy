(function () {
    'use strict';

    function AddCatController($location, cats) {
        var vm = this;

        vm.addCat = function (cat, catForm) {
            if (catForm.$valid) {
                console.log('...Add cat...');
                cats.addCat(cat)
                .then(function (catId) {
                    console.log('...Cat added...');
                    //$location.path('/cats/details' + catId);
                });
            }
        }
    }

    angular.module('catApp.controllers')
        .controller('AddCatController', ['$location', 'cats', AddCatController]);
}());