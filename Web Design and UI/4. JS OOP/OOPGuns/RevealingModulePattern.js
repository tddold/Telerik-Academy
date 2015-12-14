var db = (function(){
  var lastId = 0,
      objects = [];

    function getNextId(){
        return ++lastId;
    }

    function addObject(obj){
        obj.id = getNextId();
        objects.push(obj);
    }

    function listObjects(){
        return objects.map(function(obj){
            return {
                name: obj.name,
                id: obj.id
            };
        }).slice();
    }

    return {
        add: addObject,
        list:listObjects
    };
}());

db.add({name:'John'});
console.log(db.list());