(function () {
    'use strict';
    
    function LoginController($scope) {
        // var vm = this;
        
        $scope.login = function (user) {            
            console.log(user);
        };
        
    };
    

    angular.module('myApp.controllers')
        .controller('LoginController', ['$scope', LoginController])
}());