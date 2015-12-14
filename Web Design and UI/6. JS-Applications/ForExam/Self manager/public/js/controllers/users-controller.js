import 'jquery';
import toastr from 'toastr';
import templates from 'js/templates.js';
import data from 'js/data.js';

export default {
  register: function(context) {
    templates.get('register')
      .then(function(template) {
        context.$element().html(template());

        $('#btn-register').on('click', function() {
          var user = {
            username: $('#tb-username').val(),
            password: $('#tb-password').val(),
          };

          data.users.register(user)
            .then(function() {
              toastr.success('User register');
              console.log('User register');
            });
        });

        $('#btn-login').on('click', function() {
          var user = {
            username: $('#tb-username').val(),
            password: $('#tb-password').val(),
          };

          data.users.login(user)
            .then(function() {
              toastr.success('User logged in');
              console.log('User logged in');
              context.redirect('#/');
            });
        });
      });
  }
};
