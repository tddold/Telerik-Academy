(function () {
    'use strict';

    function HomeController(catsService) {
        var vm = this;

        catsService.searchCats({ page: 1 })
        .then(function (initialsCats) {
            vm.cats = initialsCats;
        })
    }

    angular.module('catApp.controllers')
    .controller('HomeController', ['catsService', HomeController]);
}());