var db = (function () {
    var lastId = 0,
        objects = [];

    function getNexId() {
        return ++lastId;
    }

    return {
        add: function (obj) {
            obj.id = getNexId();
            objects.push(obj);
        },
        list: function () {
            return objects.map(function (obj) {
                return {
                    name: obj.name,
                    id: obj.id
                };
            }).slice();
        }
    }
}());

db.add({name: 'John'});
db.add({name: 'Pesho'});
console.log(db.list());

//Evil hacker
var objs = db.list();
//objs.push({name: 'Hacked u'});
console.log(objs[0]);
objs[0].age = -1;
console.log(db.list());


console.log('-------------------------');

var calc = (function () {
    var lastId = 0,
        objects = [];

    function getNexId() {
        return ++lastId;
    }

    return {
        add: function (obj) {
            obj.id = getNexId();
            objects.push(obj);
        },
        list: function () {
            return objects.map(function (obj) {
                return {
                    name: obj.name,
                    id: obj.id
                }
            }).slice();
        }
    }
}());

calc.add({name: 'Pepo'});
console.log(calc.list());

//Evil hacker

var ob = calc.list();
//ob.push({name: 'hacked u'});
ob[0].age = -1;
console.log(calc.list());


console.log('-------------------------');

console.log('------------------------------------');

var book = (function () {
    var lastId = 0,
        objects = [];

    function getNexId() {
        return ++lastId;
    }

    function addObj(obj) {
        obj.id = getNexId();
        objects.push(obj);
    }

    function listObj() {
        return objects.map(function (obj) {
            return {
                name: obj.name,
                id: obj.id
            }
        }).slice();
    }

    return {
        add: addObj,
        list: listObj
    }
}());

book.add({name: 'Gogo'});
console.log(book.list());


console.log('------------------------------------');

var controls = (function () {
    function formatResult(name, value) {
        return name + ' say the result is ' + value;
    }

    var calculator = {
        init: function (name) {
            this.name = name;
            this.result = 0;
            return this;
        },
        add: function (x) {
            this.result += x;
        },
        subtract: function (x) {
            this.result -= x;
        },
        showResult: function () {
            console.log(formatResult(this.name, this.result))
        }
    };

    function getCalculator(name) {
        return Object.create(calculator).init(name);
    }

    return {
        getCalculator: getCalculator
    }
}());

//controls.getCalculator('First').add(7).showResult().subtract(2).showResult();
var calc = controls.getCalculator('First');
calc.add(7);
calc.showResult();
calc.subtract(2);
calc.showResult();


console.log('------------------------------------');
console.log('Singleton');
console.log('-------------');


var database = (function () {
    var items = [],
        db = {
            add: function (item) {
                items.push(item);
                return db;
            },
            list: function () {
                return items.slice();
            }
        };


    return {
        get: function () {
            return db;
        }
    }
}());

console.log(database.get()
    .add('John')
    .add('Pesho')
    .list());

console.log(database.get()
    .add('John1')
    .add('Pesho1')
    .list());

console.log('------------------------------------');

