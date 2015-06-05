/**
Problem 1. Make person

Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Make person";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Make person";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function for creating persons. Each person must have firstname, lastname, age and gender (true is female, false is male). Generate an array with ten person with different names, ages and genders.";

    var i,
        age,
        len = 10,
        person = [],
        grender = ['male', 'female'],
        firstNameMale = ['Ivan', 'Pesho', 'Gosho', 'Pepo', 'Neno', 'Sasho'],
        firstNameFemale = ['Iva', 'Pepa', 'Galia', 'Lili', 'Radi', 'Nina'],
        lastNameMale = ['Ivanov', 'Peshev', 'Goshov', 'Nenov', 'Mishev', 'Kolev'],
        lastNameFemale = ['Ivanova', 'Pesheva', 'Goshova', 'Nenova', 'Misheva', 'Koleva'];

    for ( i = 0; i < len; i += 1 ) {

        if ( grender[randomNumber( 0, 1 )] === 'male' ) {
            person.push( createPerson( firstNameMale[randomNumber( 0, 5 )],
                                       lastNameMale[randomNumber( 0, 5 )],
                                       age = randomNumber( 20, 35 ),
                                       grender[0] ) );
        } else {
            person.push( createPerson( firstNameFemale[randomNumber( 0, 5 )],
                                          lastNameFemale[randomNumber( 0, 5 )],
                                          age = randomNumber( 20, 35 ),
                                          grender[1] ) );
        }
    }

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Using for loops:' );
    console.log( 'Using for loops:' );
    jsConsole.writeLine();

    for ( i = 0; i < len; i += 1 ) {
        jsConsole.writeLine( person[i] );
        console.log( person[i] );
    }

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Using forEach:' );
    console.log( 'Using forEach:' );
    jsConsole.writeLine();

    person.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function createPerson( firstName, lastName, age, gender ) {
        var person = {
            firstName: firstName,
            lastName: lastName,
            age: age,
            gender: ( gender === 'female' ),
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age + ', female: ' + this.gender;
            }
        }

        return person;
    }


    function randomNumber( min, max ) {
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    }
}

/**
Problem 2. People of age

Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. People of age";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. People of age";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that checks if an array of person contains only people of age (with age 18 or greater) Use only array methods and no regular loops (for, while)";

    var i,
      age,
      len = 10,
      person = [],
      people = [],
      firstName = ['Ivan', 'Pesho', 'Gosho', 'Pepo', 'Neno', 'Sasho'],
      lastName = ['Ivanov', 'Peshev', 'Goshov', 'Nenov', 'Mishev', 'Kolev'];

    for ( i = 0; i < len; i += 1 ) {
        person.push( createPerson( firstName[randomNumber( 0, 5 )],
                                   lastName[randomNumber( 0, 5 )],
                                   age = randomNumber( 10, 25 ) ) );
    }

    people = person.filter( isGreat );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array:' );
    console.log( 'Test array:' );
    jsConsole.writeLine();

    person.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( 'People of age greater 18:' );
    console.log( 'People of age greater 18:' );
    jsConsole.writeLine();

    people.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function isGreat( item ) {
        return 18 <= item.age;
    }

    function createPerson( firstName, lastName, age, gender ) {
        var person = {
            firstName: firstName,
            lastName: lastName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age;
            }
        }

        return person;
    }

    function randomNumber( min, max ) {
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    }
}

/**
Problem 3. Underage people

Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while).

 */

function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Underage people";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Underage people";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that prints all underaged persons of an array of person.  Use Array#filter and Array#forEach.  Use only array methods and no regular loops (for, while).";

    var i,
      age,
      len = 10,
      person = [],
      people = [],
      firstName = ['Ivan', 'Pesho', 'Gosho', 'Pepo', 'Neno', 'Sasho'],
      lastName = ['Ivanov', 'Peshev', 'Goshov', 'Nenov', 'Mishev', 'Kolev'];

    for ( i = 0; i < len; i += 1 ) {
        person.push( createPerson( firstName[randomNumber( 0, 5 )],
                                   lastName[randomNumber( 0, 5 )],
                                   age = randomNumber( 10, 25 ) ) );
    }

    people = person.filter( isGreat );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array:' );
    console.log( 'Test array:' );
    jsConsole.writeLine();

    person.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( 'Underage people is:' );
    console.log( 'Underage people is:' );
    jsConsole.writeLine();

    people.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function isGreat( item ) {
        return 18 > item.age;
    }

    function createPerson( firstName, lastName, age, gender ) {
        var person = {
            firstName: firstName,
            lastName: lastName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age;
            }
        }

        return person;
    }

    function randomNumber( min, max ) {
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    }
}

/**
Problem 4. Average age of females

Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Average age of females";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Average age of females";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that calculates the average age of all females, extracted from an array of persons. Use Array#filter. Use only array methods and no regular loops (for, while).";

    var i,
      age,
      sum,
      len = 10,
      person = [],
      firstName = ['Iva', 'Pepa', 'Galia', 'Lili', 'Radi', 'Nina'],
      lastName = ['Ivanova', 'Pesheva', 'Goshova', 'Nenova', 'Misheva', 'Koleva'];

    for ( i = 0; i < len; i += 1 ) {
        person.push( createPerson( firstName[randomNumber( 0, 5 )],
                                   lastName[randomNumber( 0, 5 )],
                                   age = randomNumber( 10, 25 ) ) );
    }

    sum = person.filter( isGreat )
          .reduce( sumFemale, 0 );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array:' );
    console.log( 'Test array:' );
    jsConsole.writeLine();

    person.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( 'Average age of females is:' );
    console.log( 'Average age of females is:' );
    jsConsole.writeLine();


    jsConsole.writeLine( sum );
    console.log( sum );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function isGreat( item ) {
        return item.age;
    }

    function sumFemale( sum, item, i, arr ) {
        var count = arr.length;
        return ( sum + item.age / count );
    }

    function createPerson( firstName, lastName, age, gender ) {
        var person = {
            firstName: firstName,
            lastName: lastName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age;
            }
        }

        return person;
    }

    function randomNumber( min, max ) {
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    }
}

/**
Problem 5. Youngest person

Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. Youngest person";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. Youngest person";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that finds the youngest male person in a given array of people and prints his full name. Use only array methods and no regular loops (for, while)  Use Array#find";

    var i,
        len,
        youngest,
        len = 10,
        person = [],
        firstName = ['Ivan', 'Pesho', 'Gosho', 'Pepo', 'Neno', 'Sasho'],
        lastName = ['Ivanov', 'Peshev', 'Goshov', 'Nenov', 'Mishev', 'Kolev'];

    for ( i = 0; i < len; i += 1 ) {
        person.push( createPerson( firstName[randomNumber( 0, 5 )],
                                   lastName[randomNumber( 0, 5 )],
                                   age = randomNumber( 10, 25 ) ) );
    }



    if ( !Array.prototype.find ) {
        Array.prototype.find = function ( callback ) {
            var i,
                len;
            len = this.length;

            for ( i = 0; i < len; i += 1 ) {
                if ( callback( this[i], i, this ) ) {
                    return this[i];
                }
            }
        }
    }

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array:' );
    console.log( 'Test array:' );
    jsConsole.writeLine();

    person.forEach( function ( item ) {
        jsConsole.writeLine( item );
        console.log( item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( 'Underage people is:' );
    console.log( 'Underage people is:' );
    jsConsole.writeLine();

    youngest = person.sort( function ( x, y ) {
        return x.age - y.age;
    } ).find( function ( item ) {
        return item.age;
    } );


    jsConsole.writeLine(youngest);
    console.log( youngest );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function createPerson( firstName, lastName, age, gender ) {
        var person = {
            firstName: firstName,
            lastName: lastName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age;
            }
        }

        return person;
    }

    function randomNumber( min, max ) {
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    }
}

/**
Problem 6.

Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)

Example:

var people = {…};
var groupedByFname = group(people, 'firstname');
var groupedByAge= group(people, 'age');
 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 6.Groups people by age, first or last name";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 6.Groups people by age, first or last name";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that groups an array of people by age, first or last name. The function must return an associative array, with keys - the groups, and values - arrays with people in this groups. Use function overloading (i.e. just one function)";

    var prop,
        groupByAge,
        groupByFname,
        groupByLname,
        people = [
                { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
                { firstname: 'Bay', lastname: 'Ivan', age: 81 },
                { firstname: 'Gosho', lastname: 'Peshev', age: 21 },
                { firstname: 'Ceko', lastname: 'Petrov', age: 21 },
                { firstname: 'Misho', lastname: 'Mishev', age: 21 }
        ];

    groupByFname = group( people, 'firstname' );
    groupByLname = group( people, 'lastname' )
    groupByAge = group( people, 'age' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Group by first name: ' );

    for ( prop in groupByFname ) {
        jsConsole.writeLine( printObjArray( groupByFname[prop], 'firstname' ) );
        console.log( printObjArray( groupByFname[prop], 'firstname' ) );
    }

    jsConsole.writeLine( 'Group by last name: ' );

    for ( prop in groupByLname ) {
        jsConsole.writeLine( printObjArray( groupByLname[prop], 'lastname' ) );
        console.log( printObjArray( groupByLname[prop], 'lastname' ) );
    }

    jsConsole.writeLine( 'Group by age: ' );

    for ( prop in groupByAge ) {
        jsConsole.writeLine( printObjArray( groupByAge[prop], 'age' ) );
        console.log( printObjArray( groupByAge[prop], 'age' ) );
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function group( people, prop ) {
        var i,
            value,
            result = {};

        if ( prop === 'firstname' ) {
            for ( i in people ) {
                if ( result[people[i].firstname] ) {
                    result[people[i].firstname].push( people[i] );
                } else {
                    result[people[i].firstname] = [people[i]];
                }
            }

            return result;
        }

        if ( prop === 'lastname' ) {
            for ( i in people ) {
                if ( result[people[i].lastname] ) {
                    result[people[i].lastname].push( people[i] );
                } else {
                    result[people[i].lastname] = [people[i]];
                }
            }

            return result;
        }

        if ( prop === 'age' ) {
            for ( i in people ) {
                if ( result[people[i].age] ) {
                    result[people[i].age].push( people[i] );
                } else {
                    result[people[i].age] = [people[i]];
                }
            }

            return result;
        }
    }

    function printObjArray( arr, type ) {
        var i,
            len,
            prop,
            result = '&nbsp; &nbsp; &nbsp; &nbsp;';

        len = arr.length;

        for ( i = 0; i < len; i += 1 ) {
            for ( prop in arr[i] ) {
                if ( prop === type ) {
                    result += ' : ' + arr[i][prop] + ' -> ' + fullName( arr );
                }
            }

            function fullName( arr ) {
                result = '';
                len = arr.length;

                for ( i = 0; i < len; i += 1 ) {

                    if ( i < len - 1 ) {
                        result += arr[i].firstname + ' ' + arr[i].lastname + ', ';

                    } else {
                        result += arr[i].firstname + ' ' + arr[i].lastname;

                    }
                }

                return result;
            }

            return result;
        }
    }
}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array Methods!";
    jsConsole.clearConsole();
}

