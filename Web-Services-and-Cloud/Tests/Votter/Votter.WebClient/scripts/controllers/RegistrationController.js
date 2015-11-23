'use strict';

votterApp.controller('RegistrationController',
    function RegistrationController($scope, $resource, votterData, $location) {
        $scope.signUp = function () {
            votterData.register($scope.email, $scope.password)
                        .then(function() {
                            $location.path('signin');
                        });
        }
    }
);
