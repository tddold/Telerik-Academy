(function () {
    'use strict';

    function SearchCatsController($scope, catsService) {
        var vm = this;
        vm.currentPage = 1;
        debugger;

        catsService.searchCats()
        .then(function (initialCats) {
            vm.cats = initialCats;
        });

        $scope.$watch('request.name', function (newVal, oldVal) {
            console.log('...Cat watch...');

            catsService.searchCats($scope.request)
           .then(function (filteredCats) {
               vm.cats = filteredCats;
           });
        });


        vm.search = function (request, page) {
            request = request || {};
            request.page = page;

            vm.currentPage = page;

            console.log('...Search cat...');

            catsService.searchCats(request)
            .then(function (filteredCats) {
                debugger;
                console.log('...Cat fined...');

                vm.cats = filteredCats;
            });

        }
    }

    angular.module('catApp.controllers')
        .controller('SearchCatsController', ['$scope', 'catsService', SearchCatsController]);
}());