'use strict'

musicApp.controller('AddArtistController',
    function AddArtistController($scope, artistData) {

        $scope.saveArtist = function (artist, addArtisForm) {
            if (addArtisForm.$valid) {
                artistData.saveArtist(artist);
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