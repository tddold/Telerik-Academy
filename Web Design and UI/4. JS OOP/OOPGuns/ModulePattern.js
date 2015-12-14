var db = (function () {
    var lastId = 0,
        objects = [];

    function getNextId() {
        return ++lastId;
    }

    return {
        add: function (obj) {
            obj.id = getNextId();
            objects.push(obj);
        },
        list: function () {
            return objects
                .map(function(obj){
                    return{
                        name: obj.name,
                        id: obj.id
                    };
                })
                .slice();
        }
    }
}());

db.add({name: 'John'});
console.log(db.list());