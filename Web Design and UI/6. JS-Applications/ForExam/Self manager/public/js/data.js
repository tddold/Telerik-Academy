import 'jquery';
import 'jqueryui';
import 'sha1';

const STORAGE_AUTH_KEY = 'SPECIAL-AUTHENTICATION-KEY';

export default {
  users: {
    register: function(user) {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/users';

        var reqUser = {
          username: user.username,
          passHash: CryptoJS.SHA1(user.password).toString()
        };
        $.ajax(url, {
          type: 'POST',
          contentType: 'application/json',
          data: JSON.stringify(reqUser),
          success: function(res) {
            resolve(res);
          }
        });
      });
      return promise;
    },
    login: function(user) {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/users/auth';

        var reqUser = {
          username: user.username,
          passHash: CryptoJS.SHA1(user.password).toString()
        };
        $.ajax(url, {
          type: 'PUT',
          contentType: 'application/json',
          data: JSON.stringify(reqUser),
          success: function(res) {
            localStorage.setItem(STORAGE_AUTH_KEY, res.result.authKey);
            resolve(res);
          }
        });
      });
      return promise;
    }
  },
  todos: {
    get: function() {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/todos';
        $.ajax(url, {
          method: 'GET',
          contentType: 'application/json',
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });
      });
      return promise;
    },
    add: function(todo) {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/todos';
        $.ajax(url, {
          method: 'POST',
          contentType: 'application/json',
          data: JSON.stringify(todo),
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });
      });
      return promise;
    },
    update: function(id, state) {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/todos/' + id;
        $.ajax(url, {
          method: 'PUT',
          contentType: 'application/json',
          data: JSON.stringify({
            state: state
          }),
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });

      });
      return promise;
    }
  },
  categories: {
    get: function() {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/categories';
        $.ajax(url, {
          method: 'GET',
          contentType: 'application/json',
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });
      });
      return promise;
    }
  },
  events: {
    get: function() {
      var promise = new Promise(function(resolve, reject) {
        var url = 'api/events';
        $.ajax(url, {
          method: 'GET',
          contentType: 'application/json',
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });
      });
      return promise;
    },
    add: function() {
      var promise = new Promise(function(resolve, reject) {

        var url = 'api/events';
        $.ajax(url, {
          method: 'POST',
          contentType: 'application/json',
          data: JSON.stringify(event),
          headers: {
            'x-auth-key': localStorage.getItem(STORAGE_AUTH_KEY)
          },
          success: function(res) {
            resolve(res);
          },
          error: function(err) {
            reject(err);
          }
        });
      });
      return promise;
    }
  }


};
