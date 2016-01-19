(function () {
    'use strict';
    
    function UserListController(UsersResource) {
        var vm = this;
        
        vm.users = UsersResource.query();
       
    }

angular.module('myApp.controllers')
    .controller('UserListController', ['UsersResource', UserListController])
}());