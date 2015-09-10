import 'jquery'

export default {
  load: function(name) {
    var url = 'app/templates/' + name + '.handlebars';

    var promise = new Promise(function(resolve, reject) {
      $.ajax({
        url: url,
        success: function(data) {
          resolve(data);
        },
        error: function(err) {
          reject(err);
        }
      })
    });
    return promise;
  }
}
