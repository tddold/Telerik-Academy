var databases = (function () {
    var items =[],
        db={
            add: function(item){
                items.push(item);
                return db;
            },
            list: function(){
                return items.slice();
            }
        };

    return {
        get: function () {
            return db;
        }
    }
}());

console.log(databases.get()
    .add('John')
    .add('Pesho')
    .list()
);

console.log(databases.get()
        .add('John1')
        .add('Pesho1')
        .list()
);