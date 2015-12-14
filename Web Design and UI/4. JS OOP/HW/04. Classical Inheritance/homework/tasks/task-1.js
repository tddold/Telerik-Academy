/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {
        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.fullname = this._firstname + ' ' + this._lastname;
        }

        Object.defineProperty(Person.prototype, 'firstname',
            {
                get: function () {
                    return this._firstname;
                },
                set: function (value) {
                    isValideFnameAndLname(value);
                    this._firstname = value;
                }
            });

        Object.defineProperty(Person.prototype, 'lastname',
            {
                get: function () {
                    return this._lastname;
                },
                set: function (value) {
                    isValideFnameAndLname(value);
                    this._lastname = value;
                }
            });

        Object.defineProperty(Person.prototype, 'age',
            {
                get: function () {
                    return this._age;
                },
                set: function (value) {
                    isValideAge(value);
                    this._age = value;
                }
            });

        Object.defineProperty(Person.prototype, 'fullname',
            {
                get: function () {
                    return this.firstname + ' ' + this.lastname;
                },
                set: function (value) {
                    var name = value.split(' ');
                    this.firstname = name[0];
                    this.lastname = name[1];
                }
            });

        Person.prototype.introduce = function(){
            return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +' and I am ' + this.age + '-years-old'
        }

        function isValideFnameAndLname(value){
            var i,
                len,
                strNumber;
            if(typeof  value !== 'string' || value.length < 3 || value.length > 20){
                throw  new Error('Firstname and Lastname must always be strings between 3 and 20 characters.');
            }
            for(i=0, len = value.length; i< len; i+=1){
                strNumber = value.toLowerCase().charCodeAt(i);
                if(strNumber -97 < 0 || strNumber - 97 > 26){
                    throw new Error('Containing only Latin letters.');
                }
            }
        }

        function isValideAge(value){
            var i,
                len,
                strNumber;

            if(isNaN(value)){
                if(typeof value !== 'string'){
                    throw new Error('The setter of age can\'t  a convert value to number ')
                } else {
                    for(i=0, len = value.length; i< len; i+=1){
                        strNumber = value.charCodeAt(i);
                        if(strNumber -48 < 0 || strNumber - 48 > 9){
                            throw new Error('The setter of age can\'t  a convert value to number');
                        }
                    }
                }
            }

            value = +value;

            if(value < 0 || value > 150){
                throw new Error('Age must always be a number in the range (0, 150), inclusive');
            }
        }

        return Person;
    }());
    return Person;
}
module.exports = solve;