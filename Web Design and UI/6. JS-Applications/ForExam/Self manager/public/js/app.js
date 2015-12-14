import 'sammy';
import 'jquery';
import homeController from 'js/controllers/home-controller.js';
import userController from 'js/controllers/users-controller.js';
import todosController from 'js/controllers/todos-controller.js';
import eventsController from 'js/controllers/events-controller.js';


var containerId = '#container';
var sammyApp = Sammy(containerId, function() {
  this.get('#/', function() {
    this.redirect('#/home');
  });

  this.get('#/home', homeController.all);

  this.get('#/register', userController.register);

  this.get('#/todos', todosController.all);
  this.get('#/todos/add', todosController.add);

  this.get('#/events', eventsController.all);
  this.get('#/events/add', eventsController.add);
});


sammyApp.run('#/');
