export default {
  lenght: function(text, min, max) {
    var promise = new Promise(function(resolve, reject) {
      if (text.length >= min && text.length <= max) {
        resolve('OK');
      } else {
        reject('Tex too long');
      }
    });
    return promise;
  }
}
