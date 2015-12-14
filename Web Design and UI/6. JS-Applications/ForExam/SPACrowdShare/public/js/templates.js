import 'jquery'
import Handlebars from 'handlebars'

export default {
  load: function(name) {
    var url = 'js/templates/' + name + '.handlebars';
    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: url,
        success: function(data) {
          resolve(Handlebars.compile(data));
        },
        error: function(err) {
          reject(err);
        }
      })
    });
    return promise;
  }
}
