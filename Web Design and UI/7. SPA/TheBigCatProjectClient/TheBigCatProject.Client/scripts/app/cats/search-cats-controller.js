(function () {
    'use strict';

    function SearchCatsController($scope, cats) {
        var vm = this;
        vm.currentPage = 1;
        debugger;

        cats.searchCats()
        .then(function (initialCats) {
            vm.cats = initialCats;
        });

        $scope.$watch('request.name', function (newVal, oldVal) {
            console.log('...Cat watch...');

            cats.searchCats($scope.request)
           .then(function (filteredCats) {
               vm.cats = filteredCats;
           });
        });


        vm.search = function (request, page) {
            request = request || {};
            request.page = page;

            vm.currentPage = page;

            console.log('...Search cat...');

            cats.searchCats(request)
            .then(function (filteredCats) {
                debugger;
                console.log('...Cat fined...');

                vm.cats = filteredCats;
            });

        }
    }

    angular.module('catApp.controllers')
        .controller('SearchCatsController', ['$scope', 'cats', SearchCatsController]);
}());