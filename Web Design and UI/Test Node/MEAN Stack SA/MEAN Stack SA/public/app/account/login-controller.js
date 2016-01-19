(function () {
    'use strict';
    
    function LoginController($scope, notifirer, $location, identity, auth) {
        // var vm = this;
        $scope.identity = identity;
        
        $scope.login = function (user) {
            auth.login(user).then(function (success) {
                if (success) {
                    notifirer.success('Successful login!');
                } else {
                    notifirer.error('Username/Password combination is not valid!');
                }
            })
        };
        
        $scope.logout = function () {
            auth.logout().then(function () {
                if ($scope.user){
                    $scope.user.username = '';
                    $scope.user.password = '';
                }

                $location.path('/');
                notifirer.success('Successful logout');
               
            })
        };
    };
    
    
    angular.module('myApp.controllers')
        .controller('LoginController', ['$scope', 'notifirer', '$location', 'identity', 'auth', LoginController])
}());