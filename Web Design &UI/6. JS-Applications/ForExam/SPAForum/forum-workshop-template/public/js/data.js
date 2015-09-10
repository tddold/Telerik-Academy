var data = (function() {

  const USERNAME_STORAGE_KEY = 'username-key',
    AUTH_KEY_STORAGE_KEY = 'auth-key-key';

  function userLogin(user) {
    var promise = new Promise(function(resolve, reject) {
      var reqUser = {
        username: user.username,
        passHash: CryptoJS.SHA1(user.password).toString()
      }

      console.log(user);
      console.log(reqUser);
      $.ajax({
        url: 'api/auth',
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify(reqUser),
        success: function(user) {
          localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
          localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
          resolve(user);
        }
      });
    });
    return promise;
  }


  function userRegister(user) {
    var promise = new Promise(function(resolve, reject) {
      var reqUser = {
        username: user.username,
        passHash: CryptoJS.SHA1(user.password).toString()
      }
      $.ajax({
        url: 'api/users',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(reqUser),
        success: function(user) {
          localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
          localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
          resolve(user);
        }
      });
    });
    return promise;
  }

  function userLogout() {
    var promise = new Promise(function(resolve, reject) {
      localStorage.removeItem(AUTH_KEY_STORAGE_KEY);
      localStorage.removeItem(USERNAME_STORAGE_KEY);
      resolve();
    });
    return promise;
  }

  function usersFind() {

  }

  function getCurrentUser() {
    var username = localStorage.getItem(USERNAME_STORAGE_KEY);
    if (!username) {
      return null;
    }
    return {
      username
    };
  }

  function threadsGet() {
    var promise = new Promise(function(resolve, reject) {
      $.getJSON('api/threads', function(threads) {
        // console.log(threads);
        resolve(threads);
      })
    });
    return promise;
  }

  function threadsAdd() {
    var promise = new Promise(function(resolve, reject) {
      var body = {
        title: 'title'
      };
      console.log(body);
      $.ajax({
        url: 'api/threads',
        method: 'POST',
        data: JSON.stringify(body),
        headers: {
          'x-authkey': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
        },
        contentType: 'application/json',
        success: function(res) {
          resolve(res);
        }
      })
    });
    return promise;
  }

  function threadsById(id) {
    var promise = new Promise(function(resolve, reject) {
      $.gatJSON(`api/threads/${id}`, function(res) {
        resolve(res);
      });
    });
    return promise;
  }

  return {
    users: {
      login: userLogin,
      register: userRegister,
      logout: userLogout,
      find: usersFind,
      current: getCurrentUser
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadsById
    }
  }
}());
