const KEY = 'ITEMS-KEY',
  KEY_ID = 'ID-KEY';

var lastId = +(localStorage.getItem(KEY_ID) || 0);

function add(obj) {
  var items = JSON.parse(localStorage.getItem(KEY) || '[]');
  obj.id = lastId += 1;
  console.log(obj.id);
  localStorage.setItem(KEY_ID, lastId);
  items.push(obj);
  localStorage.setItem(KEY, JSON.stringify(items));
  return this;
}


function all() {
  var items = JSON.parse(localStorage.getItem(KEY) || '[]');
  return items;
}

function byId(id) {
  var items = JSON.parse(localStorage.getItem(KEY) || '[]');
  var item = items.find(function(item) {
    item.id === id;
  });
  return item;
}

export default {
  add, all, byId
}
