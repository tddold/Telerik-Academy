(function () {
    'use strict';

    function MainController(auth, identity) {
        var vm = this;
        // this for initial load of the page
        waitForLogin();

        vm.logout = function () {
            vm.globallySetCurrentUser = undefined;
            auth.logout();
            waitForLogin(); // this is for second login
        };

        function waitForLogin() {
            identity.getUser()
        .then(function (user) {
            vm.globallySetCurrentUser = user;
        });
        }
    }

    angular.module('catApp')
        .controller('MainController', ['auth', 'identity', MainController]);
}());