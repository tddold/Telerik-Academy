'use strict'

musicApp.controller('EditArtistController',
    function EditArtistController($scope) {

        $scope.saveArtist = function (artist, newArtisForm) {
            if (newArtisForm.$valid) {
            alert('Artist saved:' + artist.name + ' ' + artist.created); //TODO save artist
            } else {
                alert('Invalid data');
            }

        }

        $scope.cancel = function () {
            alert('cancel'); //TODO cancel, redirect
        }
    }
);