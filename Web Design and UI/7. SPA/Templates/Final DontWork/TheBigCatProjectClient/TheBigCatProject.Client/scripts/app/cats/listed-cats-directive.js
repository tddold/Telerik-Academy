(function () {
    'use strict';

    function listedCatsDirective() {
        return {
            restrict: 'A',
            template: 'partials/cats/listed-cats-directive.html'
        }
    }

    angular
        .module('catApp.directives')
        .directive('listedCatsDirective', [listedCatsDirective]);
}());