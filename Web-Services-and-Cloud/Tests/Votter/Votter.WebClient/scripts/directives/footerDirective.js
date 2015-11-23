'use strict';

votterApp.directive('footer', function() {
    return {
        restrict: 'A',
        templateUrl: 'templates/directives/footer.html',
        replace: false
    }
});