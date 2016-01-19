(function () {
    'use strict';

    function ProfileController($scope, $location, notifirer, identity, auth) {
        var vm = this;

        vm.user ={
            firstName: identity.currentUser.firstName,
            lastName: identity.currentUser.lastName
        }

        vm.update = function (user) {
            auth.update(user).then(function () {
                vm.firstName = user.firstName;
                vm.lastName = user.lastName;
                $location.path('/');
            })
        }
    }


    angular.module('myApp.controllers')
        .controller('ProfileController', ['$scope', '$location',  'notifirer', 'identity', 'auth',  ProfileController])
}());