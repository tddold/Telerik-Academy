// import

import 'bower_components/jquery/dist/jquery.js';
import Handlebars from 'bower_components/handlebars/handlebars.js'

var templateString = '<li><strong>{{this}}</strong></li>';
var template = Handlebars.compile(templateString);

function render(items) {
  var $list = $('<ul/>');
  items.map(template)
    .forEach(function(listItem) {
      $list.append(listItem);
    })
  return $list;
}

var $list = render([1, 2, 3, 4]);
$list.appendTo(document.body);
// export
