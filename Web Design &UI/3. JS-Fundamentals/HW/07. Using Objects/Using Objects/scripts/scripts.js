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

    jsConsole.writeLine('Test array: ' + arr);
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
 Problem 3. Occurrences of word
Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading.

 */

function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Occurrences of word";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Occurrences of word";
    document.getElementsByTagName( "p" )[0].innerHTML = "    Write a function that finds all the occurrences of word in a text. The search can be case sensitive or case insensitive. Use function overloading.";

    var text = 'Test text: hell, Hell, hellenist, Hellenist, hell ',
        word = 'hell';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'All words found in the text with case sensitive: ' + countWord( text, word, false, true ) );
    console.log( countWord( text, word, true, true ) );

    jsConsole.writeLine( 'All words found in the text without case sensitive: ' + countWord( text, word, false, false ) );

    jsConsole.writeLine( 'All substring found in the text with case sensitive: ' + countWord( text, word, true, true ) );
    console.log( countWord( text, word, false, true ) );

    jsConsole.writeLine( 'All substring found in the text without case sensitive: ' + countWord( text, word, true, false ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function countWord( text, word, isSubstring, caseSensetive ) {
        var searchWord = '',
            re,
            format,
            clearText,
            result = [],
            count = 0;

        format = isSubstring ? word : '\\b' + word + '\\b';

        if ( caseSensetive ) {
            searchWord = new RegExp( format, 'gm' );
        } else {
            searchWord = new RegExp( format, 'gim' );
        }

        result = text.match( searchWord );

        return result.length
    }
}

/**
Problem 4. Number of elements
Write a function to count the number of div elements on the web page
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Number of elements";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Number of elements";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function to count the number of div elements on the web page";

    var type = 'div';

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Number of "div" tags in web pages is: ' + getNumberOfElements( type ) );
    console.log( getNumberOfElements( type ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function getNumberOfElements( element ) {
        var count = document.getElementsByTagName( element ).length;

        return count;
    }
}

/**
Problem 5. Appearance count
Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. Appearance count";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. Appearance count";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.";

    var array = [3, 2, 2, 2, 3, 9, 4, 1, 1, 3, 2],
        number = 2,
        esspectResult = 4;

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.write( 'Search number is: ' + number + ' -> ' + 'Result is: ' + countNumber( array, number ) + ' -> ' + 'Test result - result is: ' + test( countNumber( array, number ), esspectResult ) );
    console.log( 'Search number is: ' + number + 'Result is: ' + countNumber( array, number ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function countNumber( arr, number ) {
        var i,
            len,
            count = 0;

        for ( i = 0, len = arr.length; i < len; i += 1 ) {
            if ( arr[i] === number ) {
                count += 1;
            }
        }

        return count;
    }

    function test( count, esspect ) {

        if ( count === esspect ) {
            return true;
        } else {
            return false;
        }
    }
}

/**
Problem 6. Larger than neighbours
Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 6. Larger than neighbours";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 6. Larger than neighbours";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).";

    var i,
        len,
        index,
        array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

    index = checkBiggerIsTwoNeighbours( array );
    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.writeLine( 'Test array: ' + array );

    for ( i = 0, len = index.length; i < len; i += 1 ) {
        jsConsole.writeLine( 'Index: ' + index[i] + ' -> ' + 'Value: ' + array[index[i]] );
        console.log( 'Index: ' + index[i] + ' -> ' + 'Value: ' + array[index[i]] );
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function checkBiggerIsTwoNeighbours( array ) {
        var i,
            len,
            arr = [];

        for ( i = 1, len = array.length; i < len - 1; i += 1 ) {
            if ( array[i] > array[i - 1] && array[i] > array[i + 1] ) {
                arr.push( i );
            }
        }

        return arr;
    }
}


/**
Problem 7. First larger than neighbours
Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there's no such element.
Use the function from the previous exercise.
 */

function task7() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 7. First larger than neighbours";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 7. First larger than neighbours";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there's no such element. Use the function from the previous exercise.";

    var i,
        index,
        testArray = [],
        array = [
                [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
                [1, 2, 3, 4]
        ];

    jsConsole.writeLine( '--------------------------------------' );

    for ( i in array ) {
        testArray = array[i];
        jsConsole.writeLine( 'Test array: ' + testArray );
        index = checkBiggerIsTwoNeighbours( testArray );

        if ( index >= 0 ) {
            jsConsole.writeLine( 'Index: ' + index + ' -> ' + 'Value: ' + testArray[index] );
            console.log( 'Index: ' + index + ' -> ' + 'Value: ' + testArray[index] );
        } else {
            jsConsole.writeLine( 'Index: ' + index );
            console.log( 'Index: ' + index );
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function checkBiggerIsTwoNeighbours( array ) {
        var i,
            len;

        for ( i = 1, len = array.length; i < len - 1; i += 1 ) {
            if ( array[i] > array[i - 1] && array[i] > array[i + 1] ) {
                return i;
            }
        }

        return -1;
    }
}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

