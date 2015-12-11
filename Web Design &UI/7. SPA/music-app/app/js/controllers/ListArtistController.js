'use strict';

musicApp.controller('ListArtistController',
    function ListArtistController($scope, artistData) {
        $scope.artists = artistData.getAllArtists();
})