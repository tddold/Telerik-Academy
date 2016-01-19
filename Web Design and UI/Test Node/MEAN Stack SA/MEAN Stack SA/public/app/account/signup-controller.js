(function () {
    'use strict';
    
    function SignUpController($location, auth, notifirer) {
        var vm = this;

        vm.signup = function (user) {
            auth.signup(user).then(function () {
                notifirer.success('Registration successful!');
                $location.path('/');
            })
        };
    };
    
    
    angular.module('myApp.controllers')
    .controller('SignUpController', ['$location', 'auth', 'notifirer', SignUpController])
}());