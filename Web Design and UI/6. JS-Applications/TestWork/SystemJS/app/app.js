// import

import 'bower_components/jquery/dist/jquery.js';
import Handlebars from 'bower_components/handlebars/handlebars.js';
import db from 'app/db.js';

var templateString = '<li><strong>{{this}}</strong></li>';
var template = Handlebars.compile(templateString);

db.add({
  name: 'John'
});
console.log(db.all());

function render(items) {
  var $list = $('<ul/>');
  items.map(template)
    .forEach(function(listItem) {
      $list.append(listItem);
    })
  return $list;
}


export {
  render
};
