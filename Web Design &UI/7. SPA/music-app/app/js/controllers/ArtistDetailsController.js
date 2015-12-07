'use strict'

musicApp.controller('ArtistDetailsController',
    function ArtistDetailsContrller($scope) {
        var artist = {
            id: 1,
            name: "Linkin Park",
            image: "/img/1.jpg",
            created: "01/10/1998",
            additionalInformation: {
                location: "USA",
                bandMember: ["Chester Benington", "Mike Shinoda", " Felix", "Joseph Han", "Rob Burton"],
                albums: 12,
                singles: 25
            },
            albums: [{
                id: 1,
                name: "Hibrid Theory",
                image: "/img/hibrid-theory.jpg",
                year: 1999,
                songs: 12,
                rating: 0,
                price: 12,
                statis: 1
            }, {
                id: 2,
                name: "Meteora",
                image: "/img/meteora.jpg",
                year: 2003,
                songs: 10,
                rating: 0,
                price: 11,
                statis: 2
            }, {
                id: 3,
                name: "A thousand suns",
                image: "/img/thousand-suns.jpg",
                year: 2008,
                songs: 14,
                rating: 0,
                price: 10,
                statis: 3
            }]
        }

        $scope.artist = artist;

        $scope.hideInformation = true;
        $scope.showMoreInfo = showMoreInfo;
        $scope.showInfoText = "Show";
        $scope.showBandMembers = showBandMembers;
        $scope.hideBandMembers = true;
        $scope.showBandMembersText = "Show";

        $scope.boldFontCss = {
            fontWeight: 'bold',
            textDecoration:'underline'
        };

        $scope.blueTextClass = 'blue-text';
        $scope.grayBackgroundClass = 'gray-background';

        function showMoreInfo() {
            if ($scope.hideInformation == true) {
                $scope.showInfoText = "Hide";
                $scope.hideInformation = false;
            } else {
                $scope.showInfoText = "Show";
                $scope.hideInformation = true;
            }
        }

        function showBandMembers() {
            if ($scope.hideBandMembers) {
                $scope.showBandMembersText = "Hide";
                $scope.hideBandMembers = false;
            } else {
                $scope.showBandMembersText = "Show";
                $scope.hideBandMembers = true;
            }
        }
    }
);