(function () {
    'use strict';
    
    function HomeController() {
        var vm = this;
        
        vm.courses = [
            { name: 'C# for Sociopaths', featured: true, published: new Date('10 / 5 / 2015') },
            { name: 'C# for Sociopaths', featured: true, published: new Date('10 / 5 / 2015') },
            { name: 'C# for Non-Sociopaths', featured: true, published: new Date('10 / 12 / 2015') },
            { name: 'Super Duper Expert C#', featured: false, published: new Date('10 / 1 / 2015') },
            { name: 'Visual Basic for Visual Basic Development', featured: true, published: new Date('7 / 12 / 2015') },
            { name: 'Pedantic C++', featured: true, published: new Date('1 / 1 / 2015') },
            { name: 'JavaScript for People over 20', featured: true, published: new Date('10 / 13 / 2015') },
            { name: 'Maintainable Code for Cowards', featured: true, published: new Date('3 / 1 / 2015') },
            { name: 'A survival Guide to Code Reviews', featured: true, published: new Date('2 / 1 / 2015') },
            { name: 'How to Job Hunt Without Alerting your Boss', featured: true, published: new Date('10 / 7 / 2015') },
            { name: 'How to Keep your Soul and go into Management', featured: false, published: new Date('8 / 1 / 2015') },
            { name: 'Telling Recruiters to Leave You Alone', featured: false, published: new Date('11 / 1 / 2015') }
        ]
    };
    
    
    angular.module('myApp.controllers')
    .controller('HomeController', [HomeController])
}());