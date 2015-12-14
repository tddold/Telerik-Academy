var person = (function () {
    'use strict';

    var person = {
        init: function (name, age) {
            this.name = name;
            this.age = age;
            return this;
        },
        get name() {
            return this._name;
        },
        set name(value) {
            if (value.length < 3) {
                throw  new Error('Sorry, name should be at least 3 symbo;s!');
            }

            this._name = value;
        },
        get age() {
            return this._age;
        },
        set age(value) {
            if (value.length < 3) {
                throw  new Error('Sorry, name should be at least 3 symbo;s!');
            }

            this._age = value;
        },
        toString: function () {
            return this.name + ' ' + this.age;
        }
    };

    return person;
}());

var student = (function (parent) {
    'use strict';

    var student = Object.create(parent);

    Object.defineProperties(student, {
        init: {
            value: function (name, age, sleep) {
                parent.init.call(this, name, age);
                this.sleep = sleep;
                return this;
            }
        },
        toString: {
            value: function () {
                var baseResult = parent.toString.call(this);
                return baseResult + ' ' + this.sleep;
            }
        }
    });

    /*  Object.defineProperty(student, 'init', {
     value: function (name, age, sleep) {
     parent.init.call(this, name, age);
     this.sleep = sleep;
     return this;
     }
     });*/

    /*student.init = function(name, age, sleep){
     parent.init.call(this, name, age);
     this.sleep = sleep;
     return this;
     };

     student.toString = function(){
     var baseResult = parent.toString.call(this);
     return baseResult + ' ' + this.sleep;
     };*/

    return student;
}(person) );

var samePerson = Object.create(person).init('Pesho', 5);
var sameStudent = Object.create(student).init('Gosho', 10, 10)

console.log(samePerson);
console.log(samePerson.age);
console.log(sameStudent);
console.log(samePerson.toString());
console.log(sameStudent.toString());

//----------------------------------------------------------------------//

var vehicle = (function () {
    var vehicle = {};

    Object.defineProperty(vehicle, 'init', {
        value: function (brand) {
            this.brand = brand;
            return this;
        }
    });

    Object.defineProperty(vehicle, 'move', {
        value: function () {
            return this.brand + ' is move...';
        }
    });

    return vehicle;
}());

var car = (function (parent) {
    var car = Object.create(parent);

    Object.defineProperty(car, 'wheels', {
        get: function () {
            return this._wheels;
        },
        set: function (value) {
            if (value > 4) {
                throw new Error('Cars mast have less than 5 wheels for some reason!');
            }

            this._wheels = value;
        }
    });

    Object.defineProperties(car, {
        init: {
            value: function (brand, wheels) {
                parent.init.call(this, brand);
                this.wheels = wheels;
                return this;
            }
        },
        move: {
            value: function () {
                return parent.move.call(this) + ' Whith ' + this.wheels + ' wheels!';
            }
        }
    });

    return car;
}(vehicle));

var samVehicle = Object.create(vehicle).init('Mercedes');

var sameCar = Object.create(car).init('Audi', 4);

console.log(samVehicle);
console.log(sameCar.move());


for(var key in sameCar){
    console.log(key + ': ' + sameCar.hasOwnProperty(key));
}


var arrObj = {
    length: 3,
    '0': 'One',
    '1':'Two',
    '2': 'Three'
};
var arr = [].slice.call(arrObj);
//returns ['One', 'Two', 'Three']

console.log(arr);