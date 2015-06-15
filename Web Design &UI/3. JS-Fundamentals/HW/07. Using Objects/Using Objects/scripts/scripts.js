/**
Problem 1. Planar coordinates

Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle.
 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Planar coordinates";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Planar coordinates";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write functions for working with shapes in standard Planar coordinate system. Points are represented by coordinates P(X, Y) Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))    Calculate the distance between two points. Check if three segment lines can form a triangle.";

    var i,
        len,
        sideA,
        sideB,
        sideC,
        points = [],
        arrX = [2, 1, -1],
        arrY = [2, -1, 1];

    for ( i = 0, len = arrX.length; i < len; i += 1 ) {
        points.push( createPoint( arrX[i], arrY[i] ) );
        console.log( points[i] );
    }

    sideA = createElements( points[0], points[1] ).dist.toFixed( 2 );
    sideB = createElements( points[0], points[2] ).dist.toFixed( 2 );
    sideC = createElements( points[2], points[1] ).dist.toFixed( 2 );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Distance between p1( ' + points[0].x + ', ' + points[0].y + ' )' + ' and p2( ' + points[1].x + ', ' + points[1].y + ' ) is: ' + sideA );
    jsConsole.writeLine( 'Distance between p1( ' + points[0].x + ', ' + points[0].y + ' )' + ' and p3( ' + points[2].x + ', ' + points[2].y + ' ) is: ' + sideB );
    jsConsole.writeLine( 'Distance between p3( ' + points[2].x + ', ' + points[2].y + ' )' + ' and p2( ' + points[1].x + ', ' + points[1].y + ' ) is: ' + sideC );

    jsConsole.writeLine( 'p1, p2 and p3 makes a triangle is: ' + checkFormTriangle( sideA, sideB, sideC ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function createPoint( x, y ) {
        return {
            'x': x,
            'y': y
        };
    }

    function createElements( p1, p2 ) {
        return {
            'p1': p1,
            'p2': p2,
            'dist': calcDistance( p1, p2 )
        };
    }

    function calcDistance( p1, p2 ) {
        return Math.sqrt(( ( p1.x - p2.x ) * ( p1.x - p2.x ) ) + ( ( p1.y - p2.y ) * ( p1.y - p2.y ) ) );
    }

    function checkFormTriangle( a, b, c ) {
        if ( a + b > c && a + c > b && b + c > a ) {
            return true;
        } else {
            return false;
        }
    }
}

/**
Problem 2. Remove elements

Write a function that removes all elements with a given value.
Attach it to the array type.
Read about prototype and how to attach methods.

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Remove elements";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Remove elements";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.";

    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

    Array.prototype.remove = function ( value ) {
        while ( this.indexOf( value ) >= 0 ) {
            this.splice( this.indexOf( value ), 1 )
        }

        return this;
    }

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array: ' + arr );
    jsConsole.writeLine( 'Result using function : ' + removeElement( arr, 1 ) );
    jsConsole.writeLine( 'Result using prototype: ' + arr.remove( 1 ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function removeElement( array, element ) {
        var i,
            len;

        for ( i = 0, len = array.length; i < len; i += 1 ) {
            if ( array[i] === element ) {
                array.splice( i, 1 );
            }

        }
        return array;

    }





}

/**
Problem 3. Deep copy

Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.

 */

function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Deep copy";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Deep copy";
    document.getElementsByTagName( "p" )[0].innerHTML = " Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.";

    var i,
        j,
        copy,
        obj = {
            str: 'String',
            num: 5,
            arr: [1, 2, 3],
            obj: {
                name: 'Pesho',
                age: 25,
                sex: 'male',
            }
        };


    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'This is input obj:' + obj );
    jsConsole.writeLine( obj.str + ' | ' + obj.num + ' | ' + obj.arr +
        ' | ' + obj.obj.name + ' | ' + obj.obj.age + ' | ' + obj.obj.sex );

    console.log( 'This is obj:' );
    console.log( obj );

    copy = deepCopy( null );


    jsConsole.writeLine( 'This is deepCopy - null: ' + copy );
    console.log( 'This is deepCopy - null: ' + copy );

    copy = deepCopy( obj );

    jsConsole.writeLine( 'This is deepCopy - obj: ' + copy );
    jsConsole.writeLine( 'Print deepCopy - obj: ' );

    for ( i in copy ) {
        jsConsole.write( i + ': ' );
        if ( i !== 'obj' ) {
            jsConsole.writeLine( copy[i] );

        } else {
            for ( j in copy[i] ) {
                jsConsole.write( j + ': ' );
                jsConsole.writeLine( copy[i][j] );
                jsConsole.write( i + ': ' );
            }
        }
    }


    console.log( 'This is deepCopy - obj: ' + copy );
    console.log( copy );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function deepCopy( obj ) {
        var prop,
            temp;

        if ( obj === null || typeof ( obj ) !== 'object' ) {
            return obj;
        }

        temp = obj.constructor(); // changed

        for ( prop in obj ) {

            temp[prop] = deepCopy( obj[prop] );

            //if ( Object.prototype.hasOwnProperty.call( obj, prop ) ) {
            //    temp[prop] = deepCopy( obj[prop] );
            //}
        }

        return temp;
    }
}

/**
Problem 4. Has property

Write a function that checks if a given object contains a given property.

var obj  = …;
var hasProp = hasProperty(obj, 'length');
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Has property";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Has property";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that checks if a given object contains a given property.";

    var obj1 = {
        lenght: undefined
    },
        obj2 = {
            1: 'yes',
            2: 'no'
        };

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'This obj1 contains a property (lenght): ' + hasProperty( obj1, 'lenght' ) );
    console.log( 'This obj1 contains a property (lenght): ' + hasProperty( obj1, 'lenght' ) );


    jsConsole.writeLine( 'This obj2 contains a property (lenght): ' + hasProperty( obj2, 'lenght' ) );
    console.log( 'This obj2 contains a property (lenght): ' + hasProperty( obj2, 'lenght' ) );


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function hasProperty( obj, prop ) {
        return obj.hasOwnProperty( prop );
    }
}

/**
Problem 5. Youngest person

Write a function that finds the youngest person in a given array of people and prints his/hers full name
Each person has properties firstname, lastname and age.

Example:

var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. Youngest person";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. Youngest person";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that finds the youngest person in a given array of people and prints his/hers full name. Each person has properties firstname, lastname and age.";

    var people = [
                { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
                { firstname: 'Bay', lastname: 'Ivan', age: 81 },
                { firstname: 'Pesho', lastname: 'Peshev', age: 21 }
    ];

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.write( 'Youngest person is: ' + checkYoungestPerson( people ) );
    console.log( 'Youngest person is: ' + checkYoungestPerson( people ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function checkYoungestPerson( arr ) {
        var i,
            fullName,
            min = 1000;

        for ( i in arr ) {
            if ( arr[i].age < min ) {
                fullName = arr[i].firstname + ' ' + arr[i].lastname;
            }
        }

        return fullName;
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
    document.getElementsByTagName( "p" )[1].innerHTML = "Using Objects!";
    jsConsole.clearConsole();
}

