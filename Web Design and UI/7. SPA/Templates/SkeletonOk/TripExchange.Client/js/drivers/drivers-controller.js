(function () {
    'use strict';

    function DriversController(drivers, identity, notifier) {
        var vm = this;
       
        vm.identity = identity;
        vm.request = {
            page: 1
        };
        vm.prevPage = function () {
            if (vm.request.page == 1) {
                return;
            }

            vm.request.page--;
            vm.filterDrivers();
        }

        vm.nextPage = function () {
            if (!vm.drivers || vm.drivers.length == 0) {
                return;
            }

            vm.request.page++;
            vm.filterDrivers();
        }

        vm.filterDrivers = function () {
            debugger;
            drivers.filterDrivers(vm.request)
                .then(function (filteredDrivers) {
                    vm.drivers = filteredDrivers;
                });
        }
        
        vm.filterDriversByName = function (test) {
            debugger;
            drivers.filterDriversByName(test)
                .then(function (filteredDriversByname) {
                    vm.drivers = filteredDriversByname;
                    console.log(drivers);
                });
        }

        drivers.gstPublicDrivers()
            .then(function (publicDrivers) {
                notifier.success('Get drivers Ok.');
                vm.drivers = publicDrivers;
            });
    }

    angular.module('myApp.controllers')
        .controller('DriversController', ['drivers', 'identity', 'notifier', DriversController])
}());