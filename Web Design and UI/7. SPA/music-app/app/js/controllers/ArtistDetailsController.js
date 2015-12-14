'use strict'

musicApp.controller('ArtistDetailsController',
    function ArtistDetailsContrller($scope, $routeParams, artistData) {

        $scope.artist = artistData.getArtist($routeParams.id);

        $scope.bandMembersShown = false;
        $scope.bandMembersShowText = 'Show';
        $scope.showAndHideMembers = showAndHideBandMembers;

        $scope.bandMembers = "band-members";
        $scope.evenBandMembers = "even-band-members";


        $scope.customStyle = {
            fontWeight: 'bold'
        }

        $scope.bandRecordsShowText = 'Info';
        $scope.bandRecordsShown = false;
        $scope.showAndHideRecords = showAndHideRecords;

        $scope.upVoteRating = upVoteRating;
        $scope.downVoteRating = downVoteRating;

        $scope.sort = 'id';


        function showAndHideBandMembers() {
            if ($scope.bandMembersShown == false) {
                $scope.bandMembersShowText = "Hide";
                $scope.bandMembersShown = true;
            } else {
                $scope.bandMembersShowText = "Show";
                $scope.bandMembersShown = false;
            }
        }

        function showAndHideRecords() {
            if ($scope.bandRecordsShown == false) {
                $scope.bandRecordsShowText = "Hide";
                $scope.bandRecordsShown = true;
            } else {
                $scope.bandRecordsShowText = "View";
                $scope.bandRecordsShown = false;
            }
        }

        function upVoteRating(album) {
            album.rating++;
        }

        function downVoteRating(album) {
            if (album.rating > 0) {
                album.rating--;
            }
        }

    }
);