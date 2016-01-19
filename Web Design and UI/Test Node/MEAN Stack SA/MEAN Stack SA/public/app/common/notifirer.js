(function () {
    'use strict';
    
    function notifirer(toastr) {
        return {
            success: function (msg) {
                toastr.success(msg);
            },
            error: function (msg) {
                toastr.error(msg);
            }
        }
    }

    angular.module('myApp.services')
    .factory('notifirer', ['toastr', notifirer])
}());