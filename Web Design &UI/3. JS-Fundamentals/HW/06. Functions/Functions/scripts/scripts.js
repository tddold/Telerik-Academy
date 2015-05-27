/**
Problem 1. English digit

Write a function that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. English digit";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. English digit";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that returns the last digit of given integer as an English word.";

    var array = [512, 1024, 12309];

    jsConsole.writeLine( '--------------------------------------' );


    jsConsole.writeLine( getEnglishDigits( array ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function getEnglishDigits( array ) {
        var resultArr = [],
            i;
        for ( i = 0; i < array.length; i += 1 ) {

            switch ( array[i] % 10 ) {
                case 0: resultArr.push( 'zero' ); break;
                case 1: resultArr.push( 'one' ); break;
                case 2: resultArr.push( 'two' ); break;
                case 3: resultArr.push( 'three' ); break;
                case 4: resultArr.push( 'four' ); break;
                case 5: resultArr.push( 'five' ); break;
                case 6: resultArr.push( 'six' ); break;
                case 7: resultArr.push( 'seven' ); break;
                case 8: resultArr.push( 'eight' ); break;
                case 9: resultArr.push( 'nine' ); break;
                default: resultArr.push( 'Not a number' ); break;
            }
        }

        return resultArr;
    }

}


/**
 Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
Example:

input	output
256	    652
123.45	54.321
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Reverse number";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Reverse number";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a function that reverses the digits of given decimal number.";


    var array = [256, 123.45];

    jsConsole.writeLine( '--------------------------------------' );


    jsConsole.writeLine( getEnglishDigits( array ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function getEnglishDigits( array ) {
        var resultArr = [],
            tmp,
            str,
            i,
            j;
        for ( i = 0; i < array.length; i += 1 ) {
            tmp = array[i].toString();
            str = '';
            for ( j = tmp.length - 1; j >= 0; j -= 1 ) {
                str += tmp[j];
            }

            resultArr.push( str );

        }

        return resultArr;
    }
}

/**
 Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 Example:
 input                            result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1    2, 2, 2

 */
function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Maximal sequence";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Maximal sequence";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the maximal sequence of equal elements in an array.";

    var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
        count = 1,
        maxSequence = 0,
        number;

    for ( var i = 1; i < array.length; i++ ) {
        if ( array[i] === array[i - 1] ) {
            count++;
        } else {
            if ( count > maxSequence ) {
                maxSequence = count;
                number = array[i - 1];
            }
            count = 1;
        }
    }

    jsConsole.writeLine( '--------------------------------------' );


    for ( var i = 0; i < maxSequence; i++ ) {
        if ( i < maxSequence - 1 ) {
            jsConsole.write( number + ', ' );
            console.log( number + ', ' );
        } else {
            jsConsole.write( number );
            console.log( number );
        }
    }
    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

}


/**
 Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 Example:

 input    result
 3, 2, 3, 4, 2, 2, 4    2, 3, 4
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Maximal increasing sequence";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Maximal increasing sequence";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the maximal increasing sequence in an array.";

    var array = [3, 2, 3, 4, 2, 2, 4],
        maxIncreasSequence = [array[0]],
        tmp = [array[0]];

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.write( maxIncreasingSequence( array ).join( ', ' ) );
    console.log( maxIncreasingSequence( array ).join() );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function maxIncreasingSequence( array ) {
        for ( var i = 1; i < array.length; i++ ) {
            if ( array[i] === array[i - 1] + 1 ) {
                tmp.push( array[i] );
            } else {
                tmp = [array[i]];
            }

            if ( tmp.length > maxIncreasSequence.length ) {
                maxIncreasSequence = tmp;
            }
        }

        return maxIncreasSequence;
    }
}

/**
 Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. Selection sort";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. Selection sort";
    document.getElementsByTagName( "p" )[0].innerHTML = "Sorting an array means to arrange its elements in increasing order." +
        " Write a script to sort an array." +
        " Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.        Hint: Use a second array";

    var array = [3, 2, 5, 4, 1, 9, 7, 6, 8],
        tmp = [array[0]];

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.write( getSelectionSort( array ).join( ', ' ) );
    console.log( getSelectionSort( array ).join() );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function getSelectionSort( array ) {
        for ( var i = 0; i < array.length - 1; i += 1 ) {
            for ( var j = i; j < array.length; j += 1 ) {
                if ( array[i] > array[j] ) {
                    tmp = [array[i]];
                    array[i] = array[j];
                    array[j] = tmp[0];
                }
            }
        }

        return array;
    }
}

/**
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 Example:

 input    result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3    4 (5 times)
 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 6. Most frequent number";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 6. Most frequent number";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the most frequent number in an array.";

    var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        number,
        tmp,
        count = 1,
        maxCount = 0;

    getMostFrequentNumber( array );

    function getMostFrequentNumber( array ) {
        for ( var i = 1; i < array.length - 1; i += 1 ) {
            tmp = array[i];

            for ( var j = i; j < array.length; j += 1 ) {
                if ( tmp === array[j] ) {
                    count++;
                }
            }


            if ( maxCount < count ) {
                maxCount = count;
                number = tmp;
            }

            count = 1;
        }

        jsConsole.writeLine( '--------------------------------------' );

        jsConsole.write( number + ' (' + maxCount + ' times)' );
        console.log( number + ' (' + maxCount + ' times)' );

        jsConsole.writeLine();
        jsConsole.writeLine( '--------------------------------------' );

    }
}


/**
 Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

function task7() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 7. Binary search";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 7. Binary search";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.";

    var array = [3, 2, 5, 4, 1, 9, 7, 6, 8],
        findNumber = 3,
        minIndex = 0,
        maxIndex = array.length - 1,
        mindIndex;

    array.sort();

    jsConsole.writeLine( '--------------------------------------' );

    jsConsole.write( 'The index of given element in a sorted array is: ' + getBinarySearch( array ) );
    console.log( 'The index of given element in a sorted array is: ' + getBinarySearch( array ) );

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );


    function getBinarySearch( array ) {

        while ( maxIndex >= minIndex ) {
            mindIndex = ( minIndex + maxIndex ) / 2 | 0;

            if ( array[mindIndex] === findNumber ) {
                return mindIndex;

            } else if ( array[mindIndex] < findNumber ) {
                minIndex = mindIndex + 1;
            } else if ( array[mindIndex] > findNumber ) {
                maxIndex = mindIndex - 1;
            }
        }

        return 'Number not found';

    }
}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

