// JS CLASSICAL INHERITANCE CHEAT SHEET

(Object.prototype.extend = function (parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
});

// Animal -------------------------------------------------------------
var Animal = (function () {

    function checkName(nameToCheck) {
        if (!nameToCheck) {
            throw Error('Name missing!')
        }

        if (!nameToCheck.length || nameToCheck.length < 3) {
            throw  Error('Name must be at least 3 symbols!')
        }
    }

    function Animal(name) {
        if (this.constructor === Animal) {
            throw new Error('Animal is abstract class, can not make instance');
        }

        this.name = name;
    }

    Object.defineProperty(Animal.prototype, 'name', {
        get: function () {
            return this._name;
        },
        set: function (value) {
            checkName(value);

            this._name = value;
        }
    });

    Animal.prototype.toString = function () {
        return 'I am animal, and my name is ' + this.name;
    };

    Animal.prototype.say = function () {
        return 'Animal I am. Yes, hmmm. ';
    };

    Animal.prototype.calcSum = function (a, b) {
        return (a + b) + this.name;
    };


    return Animal;
}());

// Mammal -------------------------------------------------------------
var Mammal = (function (parent) {

    function isInteger(value) {
        return value === parseInt(value, 10);
    }

    function throwIntegerError(type) {
        var message = type + ' must be an integer value';

        throw Error(message)
    }

    function throwCountError(type, minValue, maxValue) {
        var message = type + ' must be between' + minValue + ' and ' + maxValue + ' inclusive!';

        throw new Error(message)
    }

    function checkLegs(legs) {
        if (isInteger(legs) === false) {
            throwIntegerError('Legs');
        }

        if (legs < 2 || legs > 4) {
            throwCountError('Legs', 2, 4)
        }
    }

    function checkEyes(eyes) {
        if (isInteger(eyes) === false) {
            throwIntegerError('Eyes');
        }

        if (eyes < 2 || eyes > 4) {
            throwCountError('Eyes', 1, 3)
        }
    }

    function Mammal(name, legs, eyes) {
        parent.call(this, name);
        this.legs = legs;
        this.eyes = eyes;
    }

// ---> INHERIT THE PARENT - Object.prototype.extend - at top of the page!!
    Mammal.extend(parent); //(child instanceof parent returns true)

// ---> Other not correct way to inherit
    // Mammal.prototype.parent = parent.prototype; // work fine (child instanceof parent returns false)// can not use parent not override methods
    // Mammal.prototype = Object.create(parent.prototype);
    // Mammal.prototype = parent.prototype; // endless recursion when in iife
    // Mammal.prototype = new parent; //(child instanceof parent returns true) - DOESNT WORK when validation

// ---> Add the new properties of the child class
    Object.defineProperties(Mammal.prototype, {
        'legs': {
            get: function () {
                return this._legs;
            },
            set: function (value) {
                checkLegs(value);

                this._legs = value;
            },
            enumerable: true
        },
        'eyes': {
            get: function () {
                return this._eyes;
            },
            set: function (value) {
                checkEyes(value);

                this._eyes = value;
            },
            enumerable: true
        },
        'suck': {
            value: 'Mammal I am. Yes, hmmm. Milk I suck.. ',
            enumerable: false
        },
        'toString': {
            value: function () {
                var baseToString = parent.prototype.toString.call(this);

                return baseToString + " and I'm a mammal. I have " + this.legs + ' legs ' + 'and ' + this.eyes + ' eyes';
            },
            enumerable: true
        }
    });

    Object.defineProperty(Mammal.prototype, 'dig', {
        value: function () {
            return this._dig;
        },
        enumerable: true
    });

    Object.defineProperty(Mammal.prototype, 'bounce', {
        get: function () {
            return this._bounce;
        },
        set: function (value) {
            this._bounce = value;
        },
        enumerable: true
    });


// ---> other way to set child's properties
    //Object.defineProperty(Mammal.prototype, 'legs', {
    //    get: function () {
    //        return this._legs;
    //    },
    //    set: function (value) {
    //        checkLegs(value);
    //
    //        this._legs = value;
    //    }
    //});
    //
    //Object.defineProperty(Mammal.prototype, 'eyes', {
    //    get: function () {
    //        return this._eyes;
    //    },
    //    set: function (value) {
    //        checkEyes(value);
    //
    //        this._eyes = value;
    //    }
    //});

    //Object.defineProperty(Mammal.prototype, 'toString', {
    //    value: function () {
    //        var baseToString = parent.prototype.toString.call(this);
    //
    //        return baseToString + " and I'm a mammal. I have " + this.legs + ' legs ' + 'and ' + this.eyes + ' eyes';
    //    }
    //});

    //Mammal.prototype.toString = function () {
    //    var baseToString = parent.prototype.toString.call(this);
    //
    //    return baseToString + " and I'm a mammal. I have " + this.legs + ' legs ' + 'and ' + this.eyes + ' eyes' + 'mammal proto';
    //};

    return Mammal;
}(Animal));

// TESTS ------------------------------------------------------------

// Adding some methods after party :P
Animal.prototype.afterInheritMethod = function () {
    return 'Inherit me, hmmm. winner you are!'
};

//var someMammal = new Mammal('Pesho');
var someMammal = new Mammal('Pesho', 2, 2);

console.log(someMammal.toString());
//console.log(Animal.prototype.toString.call({name: 'Test Name' }));

console.log(someMammal instanceof Mammal);
console.log(someMammal);
console.log(someMammal.say());
console.log(someMammal.suck);
console.log(someMammal.afterInheritMethod());
console.log(Animal.prototype.calcSum.call({name: 'Pesho'}, 1, 2));

for(var prop in someMammal) {
    console.log(prop);
}