var Person = (function (){
    //'use strict';

    // validate - private method
    function isValidateName(name){
        if(typeof name !== 'string'){
            return false;
        }

        return true;
    }

    // constructor
    function Person(name, age){
        //John Resig Fix - a simple way to check if the function is not used as constructor:
        if(!(this instanceof arguments.callee)){
            return new arguments.callee(name, age);
        }

        this.name = name;                                                       // properties
        this.age = age;
    }

    // get / set
    Object.defineProperty(Person.prototype, 'name',{
        get: function(){
            return this._name;
        },
        set: function(value){
            if(!isValidateName(value)){
                throw new Error('Name is invalid');
            }

            this._name = value;
        }
    });

    // public method
    Person.prototype.toString= function(){
        return this.name + ' ' + this.age;
    };

    Person.prototype.eat = function(){
        return 'Eats...';
    };

    return Person;
}());

var Student = (function (parent) {
    'use strict';

    // function constructor
    function Student(name, age, sleep){
        parent.call(this, name, age);
        this.sleep = sleep;
    }

    // for inherit
    //Student.prototype = parent.prototype;
    Student.prototype = Object.create(parent.prototype);
    Student.prototype.constructor = Student;

    //Adding extends method
   /* Object.prototype.extends = function(parent){
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };*/

    /*//Fixing Missing Object.create(…)
    if (!Object.create) {
        Object.create = function (proto) {
            function F() {};
            F.prototype = proto;
            return new F();
        };
    };*/


    //method
    Student.prototype.toString = function(){
        var baseResult = parent.prototype.toString.call(this);
        return baseResult + ' ' + this.sleep;
    };

    return Student;
}(Person));

var samePerson = new Person('Ivo', 10);
var sameStudent = new Student('Pesho', 5, true);

console.log(samePerson);
console.log(sameStudent);
console.log(sameStudent.eat());