import 'jquery';
import Handlebars from 'handlebars';

export default {
  // var handlebars = window.handlebars || window.Handlebars,
  //   Handlebars = window.handlebars || window.Handlebars,

  get: function(name) {
    var cache = {};
    var promise = new Promise(function(resolve, reject) {
      if (cache[name]) {
        resolve(cache[name]);
        return;
      }

      var url = 'templates/' + name + '.handlebars';
      $.get(url, function(html) {
        var tempalte = Handlebars.compile(html);
        cache[name] = tempalte;
        resolve(tempalte);
      }).error(function(err) {
        reject(err);
      });
    });
    return promise;
  }
};
