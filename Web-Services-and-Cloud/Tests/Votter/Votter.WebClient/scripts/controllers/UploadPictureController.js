'use strict';

votterApp.controller('UploadPictureController',
    function UploadPictureController($scope, $resource, votterData) {

        $scope.upload = function() {
            console.log($('#exampleInputFile').val())
        }
    }
);