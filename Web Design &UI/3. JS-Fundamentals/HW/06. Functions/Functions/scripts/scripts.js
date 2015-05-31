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
        var i,
            len,
            resultArr = [];

        for ( i = 0, len = array.length; i < len; i += 1 ) {

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
        var i,
            j,
            len,
            tmp,
            str,
            resultArr = [];

        for ( i = 0, len = array.length; i < len; i += 1 ) {
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
        jsConsole.writeLine( 'Index: '  + index[i] + ' -> ' + 'Value: ' + array[index[i]]);
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
                arr.push(i );
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
        testArray=[],
        array = [
                [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
                [1,2,3,4]
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

