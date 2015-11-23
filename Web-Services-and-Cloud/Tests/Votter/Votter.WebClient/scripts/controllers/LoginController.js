'use strict';

votterApp.controller('LoginController',
    function LoginController($scope, $resource, votterData, $location) {
        $scope.signIn = function() {
            votterData.login($scope.email, $scope.password)
                        .then(function (data) {
                            $location.path('/');
                            localStorage.setItem('isLoggedIn', true);
                            localStorage.setItem('access_token', data.access_token);
                            localStorage.setItem('username', data.userName);
                        });
        }
    }
);
