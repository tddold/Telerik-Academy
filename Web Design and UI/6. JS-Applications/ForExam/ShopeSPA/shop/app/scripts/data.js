import converter from 'scripts/converter.js'

Parse.initialize("QbJSS78KUgF3SkettrekZoPaeOEfTXe2bY2tamiJ",
  "mRC3m6s9DAxFeYK0B6YcR7D6frzfqKx8ZAtshaUz");
var Shop = Parse.Object.extend("Shop"),
  Product = Parse.Object.extend("Product");

export default {
  users: {
    login: function(username, password) {
      return Parse.User.logIn(username, password);
    },
    logout: function() {
      Parse.User.logOut();
    },
    register: function(username, password) {
      var user = new Parse.User();
      user.set('username', username);
      user.set('password', password);

      return user.signUp();
    },
    current: function() {
      var promise = new Promise(function(resolve, reject) {
        var user = Parse.User.current();
        resolve(user ? user.get('username') : undefined);
      });
      return promise;
    }
  },
  shops: {
    all: function() {
      var query = new Parse.Query(Shop);
      var promise = new Promise(function(resolve, reject) {
        query.find()
          .then(function(data) {
            return data.map(function(item) {
              return converter.dbShopToShopVM(item);
            });
          })
          .then(function(data) {
            var currentUserId = Parse.User.current() ? Parse.User.current()
              .id :
              '';
            data.map(function(item) {
              item.iAmOwner = currentUserId === item.ownerId;
              return item;
            });
            resolve({
              shops: data
            });
          })
      });
      return promise;
    },
    get: function() {

    },
    add: function(shopName) {
      var shop = new Shop();
      shop.set('name', shopName);
      shop.set('owner', Parse.User.current());
      return shop.save();
    },
    remove: function(id) {
      var query = new Parse.Query(Shop);
      var promise = new Promise(function(resolve, reject) {
        query.get(id)
          .then(function(shop) {
            resolve(shop.destroy());
          });
      });
      return promise;
    }
  },
  products: {
    all: function() {

    },
    get: function() {

    },
    add: function() {

    },
    remove: function() {

    }
  }
}
