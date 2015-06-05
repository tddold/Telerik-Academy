/**
Array#every
Signature: [].every(callback);
Callback: callback(item [, index [, arr]])
Returns: Boolean
Behavior: returns TRUE if ALL the elements of the array meets the criteria in callback()
Returns FALSE if ANY of the elements does not meet the criteria in callback()
Support: everywhere


 */

function every() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#every";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#every";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Boolean Behavior: returns TRUE if ALL the elements of the array meets the criteria in callback() Returns FALSE if ANY of the elements does not meet the criteria in callback() Support: everywhere ";

    jsConsole.writeLine( '--------------------------------------' );

    function isOdd( number ) {
        return !!( number % 2 );
    }


    jsConsole.writeLine( 'Check if all the numbers in the array are odd? ' );
    jsConsole.writeLine( [1, 2, 3, 4].every( isOdd ) );
    jsConsole.writeLine( [1, 3, 5, 7].every( isOdd ) );

    console.log( [1, 2, 3, 4].every( isOdd ) );           //false
    console.log( [1, 3, 5, 7].every( isOdd ) );           //true


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Check if all the numbers are greater than 18' );

    function isGreaterThan18( number ) {
        return number > 18;
    }

    jsConsole.writeLine( [22, 23].every( isGreaterThan18 ) );     //true
    jsConsole.writeLine( [19, 18].every( isGreaterThan18 ) );     //false

    console.log( [22, 23].every( isGreaterThan18 ) );     //true
    console.log( [19, 18].every( isGreaterThan18 ) );     //false


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#some
Signature: [].some(callback);
Callback: callback(item [, index [, arr]])
Returns: Boolean
Behavior: returns TRUE if ANY of the elements of the array meets the criteria in callback()
Returns FALSE if NONE of the elements meets the criteria in callback()
Support: everywhere
 */

function some() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#some";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#some";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Boolean Behavior: returns TRUE if ANY of the elements of the array meets the criteria in callback() Returns FALSE if NONE of the elements meets the criteria in callback() Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    function isOdd( number ) {
        return !!( number % 2 );
    }


    jsConsole.writeLine( 'Check if there is at least one odd number? ' );
    jsConsole.writeLine( [1, 2, 3, 4].some( isOdd ) );
    jsConsole.writeLine( [1, 3, 5, 7].some( isOdd ) );
    jsConsole.writeLine( [2, 4, 6, 8].some( isOdd ) );

    console.log( [1, 2, 3, 4].some( isOdd ) );            //true
    console.log( [1, 3, 5, 7].some( isOdd ) );            //true
    console.log( [2, 4, 6, 8].some( isOdd ) );            //false

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Check if at least one number greater than 18' );

    function isGreaterThan18( number ) {
        return number > 18;
    }

    jsConsole.writeLine( [22, 23].some( isGreaterThan18 ) );     //true
    jsConsole.writeLine( [19, 18].some( isGreaterThan18 ) );     //true
    jsConsole.writeLine( [17, 18].some( isGreaterThan18 ) );     //false

    console.log( [22, 23].some( isGreaterThan18 ) );     //true
    console.log( [19, 18].some( isGreaterThan18 ) );     //true
    console.log( [17, 18].some( isGreaterThan18 ) );     //false

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#filter
Signature: [].filter(callback);
Callback: callback(item [, index [, arr]])
Returns: Array
Behavior: extracts in a new array only the elements that meet the criteria in callback()
Returns empty array, if no element meets the criteria
Support: everywhere
 */

function filter() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#filter";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#filter";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Array Behavior: extracts in a new array only the elements that meet the criteria in callback() Returns empty array, if no element meets the criteria Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    function isOdd( number ) {
        return !!( number % 2 );
    }

    jsConsole.writeLine( 'Extract the odd numbers from the array ' );
    jsConsole.writeLine( '[' + [1, 2, 3, 4].filter( isOdd ) + ']' );
    jsConsole.writeLine( '[' + [1, 3, 5, 7].filter( isOdd ) + ']' );
    jsConsole.writeLine( '[' + [2, 4, 6, 8].filter( isOdd ) + ']' );

    console.log( [1, 2, 3, 4].filter( isOdd ) );            //[1, 3]
    console.log( [1, 3, 5, 7].filter( isOdd ) );            //[1, 3, 5, 7]
    console.log( [2, 4, 6, 8].filter( isOdd ) );            //[]

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Returns the numbers in a given range' );

    function inRange( min, max ) {
        return function ( item ) {
            return min <= item && item <= max;
        };
    }

    var numbers = [2, 3, 4, 5, 6, 7, 8];


    jsConsole.writeLine( '[' + numbers.filter( inRange( 4, 7 ) ) + ']' );       //[4, 5, 6, 7]
    jsConsole.writeLine( '[' + numbers.filter( inRange( 2, 4 ) ) + ']' );       //[2, 3, 4]

    console.log( numbers.filter( inRange( 4, 7 ) ) );       //[4, 5, 6, 7]
    console.log( numbers.filter( inRange( 2, 4 ) ) );       //[2, 3, 4]


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#reduce
Signature: [].reduce(callback, initial);
Callback: callback(item [, index [, arr]])
Returns: Object
Behavior: returns a single object, the result of the callback()
Support: everywhere

 */

function reduce() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#reduce";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#reduce";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Object Behavior: returns a single object, the result of the callback() Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Calculates the sum and product on numbers' );

    var sum = [1, 2, 3, 4].reduce( function ( sum, number ) {
        return sum + number;
    }, 0 );

    var product = [1, 2, 3, 4].reduce( function ( sum, number ) {
        return sum * number;
    }, 1 );

    jsConsole.writeLine( sum );
    jsConsole.writeLine( product );

    console.log( sum );               //10
    console.log( product );           //24


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Flattens array' );

    var arr = [1, [2, 3], [4], [5, 6], 7];

    function flatten( arr, item ) {
        if ( Array.isArray( item ) ) {
            return arr.concat( item );
        }

        return arr.concat( [item] );
    }

    jsConsole.writeLine( '[' + arr.reduce( flatten, [] ) + ']' );       //[ 1, 2, 3, 4, 5, 6, 7 ]

    console.log( arr.reduce( flatten, [] ) ); //[ 1, 2, 3, 4, 5, 6, 7 ]


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#map
Signature: [].map(callback);
Callback: callback(item [, index [, arr]])
Returns: Object
Behavior: returns a new array with the same size. Each element is mapped, based on callback()
Support: everywhere

 */

function map() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#map";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#map";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Object Behavior: returns a new array with the same size. Each element is mapped, based on callback() Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Calculates the sum and product on numbers' );

    var squares = [1, 2, 3, 4, 5].map( function ( number ) {
        return number * number;
    } );

    jsConsole.writeLine( squares );
    console.log( squares ); //prints [ 1, 4, 9, 16, 25 ]

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Parses a matrix given as an array of rows into an array of arrays of numbers' );

    var lines = ['1 2 3',
                '4 5 6'];
    var matrix = lines.map( function ( line ) {
        return line.split( ' ' ).map( Number );
    } );

    jsConsole.writeLine( '[' + matrix + ']' );// [[1, 2, 3], [4, 5, 6]]
    console.dir( matrix );
    console.log( matrix );
    console.log( matrix[0] );
    console.log( matrix[1] );
    // [[1, 2, 3],
    // [4, 5, 6]]

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Parses a  an array of strings into an array of numbers' );

    var arrOfStrings = ['1', '2', '3', '4', '5', '6'],
        arrOfNumbers = arrOfStrings.map( Number );
    jsConsole.writeLine( '[' + arrOfStrings + ']' );    // ['1', '2', '3', '4', '5', '6']
    jsConsole.writeLine( '[' + arrOfNumbers + ']' );    // [1, 2, 3, 4, 5, 6]

    console.log( arrOfStrings );     // ['1', '2', '3', '4', '5', '6']
    console.log( arrOfNumbers );     // [1, 2, 3, 4, 5, 6]

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

}

/**
Array#forEach
Signature: [].forEach(callback);
Callback: callback(item [, index [, arr]])
Returns: undefined
Behavior: iterates the elements and passes each element as argument to callback
Much like a for-of loop where the callback is the body of the loop
Support: everywhere
 */

function forEach() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#forEach";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#forEach";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: undefined Behavior: iterates the elements and passes each element as argument to callback Much like a for-of loop where the callback is the body of the loop Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Print the elements of an array with their index' );

    var numbers = ['One', 'Two', 'Three', 'Four', 'Five'];
    numbers.forEach( function ( item, index ) {
        jsConsole.writeLine( 'Item at ' + index + ' has value ' + item );
        console.log( 'Item at ' + index + ' has value ' + item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Call a method for each object in an array' );

    function createPerson( name, age ) { };

    var people = [createPerson( 'Peter', 13 ),
                  createPerson( 'John', 18 ),
                  createPerson( 'Susan', 21 )];


    //people.forEach( function ( person ) {
    //    person.introduce();
    //} );

    console.log( people );
    console.log( people.introduce );
    console.dir( people );

    people.forEach( function ( item, index ) {
        jsConsole.writeLine( 'Item at ' + index + ' has value ' + item );
        console.log( 'Item at ' + index + ' has value ' + item );
    } );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#find
Signature: [].find(callback);
Callback: callback(item [, index [, arr]])
Returns: Object or undefined
Behavior: returns the leftmost element in the array, that meets the criteria in callback
If no such element is found, returns undefined
Support: Almost nowhere, needs a polyfill
 */

function find() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#find";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#find";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Object or undefined Behavior: returns the leftmost element in the array, that meets the criteria in callback If no such element is found, returns undefined Support: Almost nowhere, needs a polyfill";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Find the leftmost odd number, greater than 5' );

    var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    jsConsole.writeLine( numbers.find( function ( item ) {
        return !!( item % 2 ) && item > 5;
    } ) );            //prints 7

    console.log( numbers.find( function ( item ) {
        return !!( item % 2 ) && item > 5;
    } ) );            //prints 7


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Find the leftmost odd number, that is after index 3' );

    var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    jsConsole.writeLine( numbers.find( function ( item, index ) {
        return index > 3 && !!( item % 2 );
    } ) );            //prints 5


    console.log( numbers.find( function ( item, index ) {
        return index > 3 && !!( item % 2 );
    } ) );            //prints 5


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#findIndex
Signature: [].findIndex(callback);
Callback: callback(item [, index [, arr]])
Returns: Number or -1
Behavior: returns the index of the leftmost element in the array, that meets the criteria in callback
If no such element is found, returns -1
Support: Almost nowhere, needs a polyfill
 */

function findIndex() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#findIndex";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#findIndex";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Number or -1 Behavior: returns the index of the leftmost element in the array, that meets the criteria in callback If no such element is found, returns -1 Support: Almost nowhere, needs a polyfill";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Find the index of leftmost odd number, greater than 5' );

    var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    jsConsole.writeLine( numbers.findIndex( function ( item ) {
        return !!( item % 2 ) && item > 5;
    } ) );            //prints 6(element 7)

    console.log( numbers.findIndex( function ( item ) {
        return !!( item % 2 ) && item > 5;
    } ) );            //prints 6(element 7)



    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Find the index of the leftmost odd number, that is after index 3' );

    var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    jsConsole.writeLine( numbers.findIndex( function ( item, index ) {
        return index > 3 && !!( item % 2 );
    } ) );            //prints 4(element 5)


    console.log( numbers.findIndex( function ( item, index ) {
        return index > 3 && !!( item % 2 );
    } ) );            //prints 4(element 5)



    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#sort
Signature: [].sort(callback);
Callback: callback(obj1, obj2)
Returns: undefined
Behavior: sorts the items from the array, based on the callback()
Support: everywhere

 */

function sort() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#sort";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#sort";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: undefined Behavior: sorts the items from the array, based on the callback() Support: everywhere";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Sorts an array of numbers descending ' );

    var numbers = [5, 1, 2, 4, 6];
    numbers.sort( function ( x, y ) {
        return y - x;
    } );

    jsConsole.writeLine( numbers );
    console.log( numbers );             //[ 6, 5, 4, 2, 1 ]

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Sorts array of people by name' );

    function createPerson( name, age ) { };

    var people = [createPerson( 'Peter', 13 ),
                  createPerson( 'John', 18 ),
                  createPerson( 'Susan', 21 )
    ];
    people.sort( function ( p1, p2 ) {
        return p1.name > p2.name;
    } );

    jsConsole.writeLine( people );           

    console.log( people );              // John, Peter, Susan

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
Array#fill
Signature: [].fill(callback);
Callback: callback(value [, from [, to]])
Returns: Array
Behavior: fills an array with the given value
Support: Almost nowhere, needs a polyfill
 */

function fill() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Array#fill";
    document.getElementsByTagName( "p" )[1].innerHTML = "Array#fill";
    document.getElementsByTagName( "p" )[0].innerHTML = "Returns: Array Behavior: fills an array with the given value Support: Almost nowhere, needs a polyfill";

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Fills an array with the number 1 ' );

    var arr = [],
     count = 15;
    arr[count - 1] = undefined;
    arr.fill(1);


    jsConsole.writeLine( arr );
    console.log(arr);

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Create array of arrays' );

    var arr = [],
        count = 5;
    arr[count - 1] = undefined;

    arr.fill([1, 2, 3, 4, 5]);


    jsConsole.writeLine( arr );
    console.log(arr);

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}


function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}