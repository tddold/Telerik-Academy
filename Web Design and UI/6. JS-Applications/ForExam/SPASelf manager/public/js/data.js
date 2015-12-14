var data = function() {

  const STORAGE_AUTH_KEY = 'SPECIAL-AUTHENTICATION-KEY';

  /* Users */
  function register(user) {
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
  }

  function login(user) {
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

  /* TODOs */
  function todosGet() {
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
  }

  function todosAdd(todo) {
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
  }

  function todosUpdate(id, state) {
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

  /* Categories */
  function categoriesGet() {
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

  /* Events */
  function eventsGet() {
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
  }

  function eventsAdd(event) {
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

  return {
    users: {
      register: register,
      login: login
    },
    todos: {
      get: todosGet,
      add: todosAdd,
      update: todosUpdate
    },
    categories: {
      get: categoriesGet
    },
    events: {
      get: eventsGet,
      add: eventsAdd
    }
  };

}();
