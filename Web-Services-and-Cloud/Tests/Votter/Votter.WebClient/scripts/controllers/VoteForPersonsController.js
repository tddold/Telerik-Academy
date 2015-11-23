'use strict';

votterApp.controller('VoteForPersonsController',
    function VoteForPersonsController($scope, $rootScope, author, copyright, $location) {
        $scope.personA = "Monica";
        $scope.ImageUrlA = "http://brato.bg/wp-content/uploads/2013/08/OIUVS2CG-georgia-salpa.jpg";

        $scope.personB = "Vanesa";
        $scope.ImageUrlB = "http://2.bp.blogspot.com/-GQCg6I5bweg/USge14TrlvI/AAAAAAAACMk/4RUG878QC_Y/s1600/526770_295620960530927_1039663593_n.jpg";
    }
);