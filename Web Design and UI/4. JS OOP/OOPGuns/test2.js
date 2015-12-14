var animal = (function () {
    var animal = {
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
                throw new Error('Error1');
            }

            this._name = value;
        },
        toString: function () {
            return this.name + ' ' + this.age;
        }
    };

    return animal;
}());


var dog = (function (parent) {
    var dog = Object.create(parent);

    Object.defineProperties(dog, {
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

    return dog;
}(animal));


var someAnimal = Object.create(animal).init('Pesho', 5);

var someDog = Object.create(dog).init('Goro', 10, true);
console.log(someDog);
console.log(someDog.toString());

console.log(Object.getPrototypeOf(someDog));

var mammal = (function () {
    var mammal = {
        init: function (name, age) {
            this.name = name;
            this.age = age;
            return this;
        },
        toString: function () {
            return this.name + ' ' + this.age;
        }
    };

    Object.defineProperties(mammal, {
        name: {
            get: function () {
                return this._name;
            },
            set: function (value) {
                if (value.length < 3) {
                    throw new Error('Error 2')
                }

                this._name = value;
            }
        },
        age: {
            get: function () {
                return this._age;
            },
            set: function (value) {
                if (value < 10) {
                    throw new Error('Error 3');
                }

                this._age = value;
            }
        }
    });

    return mammal;
}());

var cat = (function (parent) {
    var cat = Object.create(parent);


    Object.defineProperties(cat, {
        init: {
            value: function (name, age, sleep) {
                parent.init.call(this, name, age);
                this.sleep = sleep;
                return this;
            }
        },
        toString: function () {
            var baserResult = parent.toString.call(this);
            return baserResult + ' ' + this.sleep;
        }
    });

    return cat;
}(mammal));

var someCat = Object.create(cat).init('Joro', 12, true);

console.log(someCat);


var person = (function () {
    var person = {
        init: function (name, age) {
            this.name = name;
            this.age = age;
            return this;
        },
        toString: function () {
            return this.name + ' ' + this.age;
        }
    };

    Object.defineProperties(person, {
        name: {
            get: function () {
                return this._name;
            },
            set: function (value) {
                if (value.length < 3) {
                    throw new Error('Error person name')
                }

                this._name = value;
            }
        },
        age: {
            get: function () {
                return this._age;
            },
            set: function (value) {
                if (value < 10) {
                    throw new Error('Error person age');
                }

                this._age = value;
            }
        }
    });

    return person;
}());

var student = (function (parent) {
    var student = Object.create(parent);

    Object.defineProperties(student, {
        init: {
            value: function (name, age, grad) {
                parent.init.call(this, name, age);
                this.grad = grad;
                return this;
            }
        },
        toString: {
            value: function () {
                var baseResult = parent.toString.call(this);
                return baseResult + ' ' + this.grad;
            }
        }
    });

    return student;
}(person));

var somePerson = Object.create(person).init('Sisi', 18);
var someStudent = Object.create(student).init('Sasho', 14, 3);

console.log(someStudent);
console.log(person.toString());
console.log(somePerson.toString());
console.log(someStudent.toString());


var shape = (function () {
    var shape = {
        init: function (width, height) {
            this.width = width;
            this.height = height;
            return this;
        },
        get height() {
            return this._height;
        },
        set height(value) {
            if (value < 10) {
                throw new Error('Error shape height');
            }

            this._height = value;
        },
        toString: function () {
            return 'Width: ' + this.width + ' / ' + 'Height: ' + this.height;
        },
        jumps: function () {
            return 'Jumps............';
        }
    };

    Object.defineProperties(shape, {
        width: {
            get: function () {
                return this._width;
            },
            set: function (value) {
                if (value < 10) {
                    throw new Error('Error shape width');
                }

                this._width = value;
            }
        }
    });

    return shape;
}());

var rect = (function (parent) {

    var rect = Object.create(parent);

    Object.defineProperties(rect, {
        init: {
            value: function (width, height, area) {
                parent.init.call(this, width, height);
                this.area = area;
                return this;
            }
        },
        toString: {
            value: function () {
                var baseResult = parent.toString.call(this);
                return baseResult + ' / ' + 'Area: ' + this.area;
            }
        }
    });

    return rect;
}(shape));

var someRect = Object.create(rect).init(12, 15, 33);

console.log(someRect);
console.log(someRect.toString());
console.log(someRect.jumps());


var vehicle = (function () {
    var vehicle = {
        init: function (brand) {
            this.brand = brand;
            return this;
        },
        move: function () {
            return this.brand + ' is moving...';
        }
    };

    return vehicle;
}());

var car = (function (parent) {
    var car = Object.create(parent);


    Object.defineProperties(car, {
        init: {
            value: function (brand, wheels) {
                parent.init.call(this, brand);
                this.wheels = wheels;
                return this;
            }
        },
        wheels: {
            get: function () {
                return this._wheels;
            },
            set: function(value){
                if(value > 4){
                    throw new Error('Error number of wheels.')
                }

                this._wheels = value;
            }
        },
        move: {
            value: function () {
                var baseResult = parent.move.call(this);
                return baseResult + ' With ' + this.wheels + ' wheels.';
            }
        },
        enumerable: {
            value: true
        }
    });


    return car;
}(vehicle));

var someVehicle = Object.create(vehicle).init('Mercedes');
var someCar = Object.create(car).init('Audi', 4);

console.log(someVehicle);
console.log(someCar.move());

for (var key in someCar){
    console.log(key + ': ' + someCar.hasOwnProperty(key));
}