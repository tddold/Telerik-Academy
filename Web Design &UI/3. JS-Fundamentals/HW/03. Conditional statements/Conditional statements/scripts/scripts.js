/**
    Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
Examples:

a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5

 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second. As a result print the values a and b, separated by a space.";

    var i,
        len,
        arrayA = [5, 3, 5.5],
        arrayB = [2, 4, 4.5];




    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        jsConsole.write( 'input ' + ' ' + arrayA[i] + ' ' + arrayB[i] + ' -> ' );
        isGreater( arrayA[i], arrayB[i] );
    }

    function isGreater( a, b ) {
        if ( a < b ) {
            jsConsole.writeLine( a + ' ' + b );
            console.log( a + ' ' + b );
        } else {
            jsConsole.writeLine( b + ' ' + a );
            console.log( b + ' ' + a );
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

}


/**
Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	  b	     c	    result
5	  2	     2	    +
-2	 -2	     1	    +
-2	  4	     3	    -
0	 -2.5	 4	    0
-1	 -0.5	-5.1	-
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.  Use a sequence of if operators.";


    var i,
        len,
        arrayA = [5, -2, -2, 0, -1],
        arrayB = [2, -2, 4, -2.5, -0.5],
        arrayC = [2, 1, 3, 4, -5.1];

    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        jsConsole.write( 'input ' + ' ' + arrayA[i] + ' ' + arrayB[i] + ' ' + arrayC[i] + ' -> ' );
        checkSing( arrayA[i], arrayB[i], arrayC[i] );
    }


    function checkSing( a, b, c ) {
        if ( a === 0 || b === 0 || c === 0 ) {
            jsConsole.writeLine( 'Result is: "0"' );
            console.log( 'Result is: "0"' );
        } else if ( a < 0 && b < 0 && c < 0 ) {
            jsConsole.writeLine( 'Result is: "-"' );
            console.log( 'Result is: "-"' );
        } else if ( a < 0 && ( b > 0 && c > 0 ) ||
                   b < 0 && ( a > 0 && c > 0 ) ||
                   c < 0 && ( a > 0 && b > 0 ) ) {
            jsConsole.writeLine( 'Result is: "-"' );
            console.log( 'Result is: "-"' );
        } else {
            jsConsole.writeLine( 'Result is: "+"' );
            console.log( 'Result is: "+"' );
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}


/**
Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
Use nested if statements.
Examples:

a	     b	     c	     biggest
5	     2	     2	     5
-2	    -2	     1	     1
-2	     4	     3	     4
0	    -2.5	 5	     5
-0.1	-0.5	-1.1	-0.1

 */
function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. The biggest of Three";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. The biggest of Three";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the biggest of three numbers. Use nested if statements.";

    var i,
        len,
        arrayA = [5, -2, -2, 0, -0.1],
        arrayB = [2, -2, 4, -2.5, -0.5],
        arrayC = [2, 1, 3, -2.5, -1.1];



    jsConsole.writeLine( '--------------------------------------' );


    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        jsConsole.write( 'input ' + ' ' + arrayA[i] + ' ' + arrayB[i] + ' ' + arrayC[i] + ' -> ' );

        jsConsole.writeLine( 'Biggest number is: ' + isBiggest( arrayA[i], arrayB[i], arrayC[i] ) );
        console.log( 'Biggest number is: ' + isBiggest( arrayA[i], arrayB[i], arrayC[i] ) );
    }


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );


    function isBiggest( a, b, c ) {
        if ( a > b ) {
            if ( a > c ) {
                return a;
            } else {
                return c;
            }
        } else {
            if ( b > c ) {
                return b;
            } else {
                return c;
            }
        }
    }

}


/**
Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

 a	     b	     c	     result
 5	     1	     2	     5 2 1
-2	    -2	     1	     1 -2 -2
-2	     4	     3	     4 3 -2
 0	    -2.5	 5	     5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
 10	     20	     30	     30 20 10
 1	     1	     1	     1 1 1

 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Sort 3 numbers";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Sort 3 numbers";
    document.getElementsByTagName( "p" )[0].innerHTML = "Sort 3 real values in descending order. Use nested if statements. Note: Don't use arrays and the built-in sorting functionality.";

    var i,
        len,
        arrayA = [5, -2, -2, 0, -1.1, 10, 1],
        arrayB = [1, -2, 4, -2.5, -0.5, 20, 1],
        arrayC = [2, 1, 3, 5, -0.1, 30, 1];

    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        jsConsole.write( 'Result is: ' );
        console.log( 'Result is: ' );
        isSorted( arrayA[i], arrayB[i], arrayC[i] );
        jsConsole.write( '' );
        console.log( '' );
    }



    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );

    function isSorted( a, b, c ) {
        if ( a > b ) {
            if ( a > c ) {
                if ( b > c ) {
                    jsConsole.writeLine( a + ' ' + b + ' ' + c );
                    console.log( a + ' ' + b + ' ' + c );
                } else {
                    jsConsole.writeLine( a + ' ' + c + ' ' + b );
                    console.log( a + ' ' + c + ' ' + b );
                }
            } else {
                jsConsole.writeLine( c + ' ' + a + ' ' + b );
                console.log( c + ' ' + a + ' ' + b );
            }
        } else {
            if ( b > c ) {
                if ( a > c ) {
                    jsConsole.writeLine( b + ' ' + a + ' ' + c );
                    console.log( b + ' ' + a + ' ' + c );
                } else {
                    jsConsole.writeLine( b + ' ' + c + ' ' + a );
                    console.log( b + ' ' + c + ' ' + a );
                }
            } else {
                jsConsole.writeLine( c + ' ' + b + ' ' + a );
                console.log( c + ' ' + b + ' ' + a );
            }
        }
    }


}

/**
Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
Examples:

digit	result
 2	    two
 1	    one
 0	    zero
 5	    five
-0.1	not a digit
 hi	    not a digit
 9	    nine
 10	    not a digit

 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 5. Digit as word";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 5. Digit as word";
    document.getElementsByTagName( "p" )[0].innerHTML = "SWrite a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print \"not a digit\" in case of invalid input. Use a switch statement.";

    var i,
        len,
        array = [2, 1, 0, 5, -0.1, 'hi', 9, 10];

    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = array.length; i < len; i += 1 ) {
        jsConsole.write( 'input ' + ' ' + array[i] + ' -> ' );


        switch ( array[i] ) {

            case 0:
                jsConsole.writeLine( 'zero ' );
                console.log( 'zero' );
                break;
            case 1:
                jsConsole.writeLine( 'one ' );
                console.log( 'one' );
                break;
            case 2:
                jsConsole.writeLine( 'two ' );
                console.log( 'two' );
                break;
            case 3:
                jsConsole.writeLine( 'four ' );
                console.log( 'three' );
                break;
            case 4:
                jsConsole.writeLine( 'zero ' );
                console.log( 'four' );
                break;
            case 5:
                jsConsole.writeLine( 'five ' );
                console.log( 'five' );
                break;
            case 6:
                jsConsole.writeLine( 'six ' );
                console.log( 'six' );
                break;
            case 7:
                jsConsole.writeLine( 'seven ' );
                console.log( 'seven' );
                break;
            case 8:
                jsConsole.writeLine( 'eight ' );
                console.log( 'eight' );
                break;
            case 9:
                jsConsole.writeLine( 'nine ' );
                console.log( 'nine' );
                break;
            default:
                jsConsole.writeLine( 'not a digit ' );
                console.log( 'not a digit' );
                break;
        }
    }


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );


}

/**
Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
Note: Quadratic equations may have 0, 1 or 2 real roots.

Examples:

a	    b	 c	roots
2	    5	-3	x1=-3; x2=0.5
-1	    3	 0	x1=3; x2=0
-0.5	4	-8	x1=x2=4
5	    2	 8	no real roots

 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 6. Quadratic equation";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 6. Quadratic equation";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Calculates and prints its real roots. Note: Quadratic equations may have 0, 1 or 2 real roots.";

    var i,
        len,
        arrayA = [2, -1, -0.5, 5],
        arrayB = [5, 3, 4, 2],
        arrayC = [-3, 0, -8, 8];


    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        quadraticEquations( arrayA[i], arrayB[i], arrayC[i] );
    }

    function quadraticEquations( a, b, c ) {
        var d,
            x,
            x1,
            x2;

        d = b * b - 4 * a * c;

        if ( d < 0 ) {
            jsConsole.writeLine( 'no real roots' );
            console.log( 'no real roots' );
        } else if ( d === 0 ) {
            x = -b / ( 2 * a );
            jsConsole.writeLine( 'x1 = x2= ' + x );
            console.log( 'x1 = x2= ' + x );
        } else {
            x1 = ( -b - Math.sqrt(( b * b ) - ( 4 * a * c ) ) ) / ( 2 * a );
            x2 = ( -b + Math.sqrt(( b * b ) - ( 4 * a * c ) ) ) / ( 2 * a );
            jsConsole.writeLine( 'x1 = ' + x1 + '; ' + 'x2 = ' + x2 );
            console.log( 'x1 = ' + x1 + '; ' + 'x2 = ' + x2 );
        }
    }


    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );


}


/**
 Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
Use nested if statements.
Examples:

 a	     b	     c	     d	 e	     biggest
 5	     2	     2	     4	 1	     5
-2	    -22	     1	     0	 0	     1
-2	     4	     3	     2	 0	     4
 0	    -2.5	 0	     5	 5	     5
-3	    -0.5	-1.1	-2	-0.1	-0.1


 */

function task7() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 7. The biggest of five numbers";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 7. The biggest of five numbers";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the greatest of given 5 variables. Use nested if statements.";

    var i,
    len,
    arrayA = [5, -2, -2, 0, -3],
    arrayB = [2, -22, 4, -2.5, -0.5],
    arrayC = [2, 1, 3, 0, -1.1],
    arrayD = [4, 0, 2, 5, -2],
    arrayE = [1, 0, 0, 5, -0.1];



    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = arrayA.length; i < len; i += 1 ) {
        jsConsole.write( 'input ' + ' ' + arrayA[i] + ' ' + arrayB[i] + ' ' + arrayC[i] + ' ' + arrayD[i] + ' ' + arrayE[i] + ' -> ' );
        isBiggest( arrayA[i], arrayB[i], arrayC[i], arrayD[i], arrayE[i] );
    }

    function isBiggest( a, b, c, d, e ) {
        if ( a > b ) {
            if ( a > c ) {
                if ( a > d ) {
                    if ( a > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + a );
                        console.log( 'Biggest is: ' + a );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                } else {
                    if ( d > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + d );
                        console.log( 'Biggest is: ' + d );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                }
            } else {
                if ( c > d ) {
                    if ( c > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + c );
                        console.log( 'Biggest is: ' + c );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                } else {
                    if ( d > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + d );
                        console.log( 'Biggest is: ' + d );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                }
            }
        } else {
            if ( b > c ) {
                if ( b > d ) {
                    if ( b > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + b );
                        console.log( 'Biggest is: ' + b );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                } else {
                    if ( d > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + d );
                        console.log( 'Biggest is: ' + d );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                }
            } else {
                if ( c > d ) {
                    if ( c > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + c );
                        console.log( 'Biggest is: ' + c );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                } else {
                    if ( d > e ) {
                        jsConsole.writeLine( 'Biggest is: ' + d );
                        console.log( 'Biggest is: ' + d );
                    } else {
                        jsConsole.writeLine( 'Biggest is: ' + e );
                        console.log( 'Biggest is: ' + e );
                    }
                }
            }
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );
}

/**
 Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
Examples:

numbers	number as words
0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine

 */

function task8() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 8. Number as words";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 8. Number as words";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that converts a number in the range [0...999] to words, corresponding to its English pronunciation.";

    var i,
        len,
        firstNumber,
        secondNumber,
        thirdNumber,
        hundredsNumbers,
        tenthsNumbers,
        numbers,
        array = [0, 9, 10, 12, 19, 25, 98, 98, 273, 400, 501, 617, 711, 999];




    jsConsole.writeLine( '--------------------------------------' );

    for ( i = 0, len = array.length; i < len; i += 1 ) {
        jsConsole.write('Input ' + ' ' + array[i] + ' -> ')
        checkNumber( array[i].toString() );
    }

    function checkNumber( number ) {
        if ( number.length === 1 ) {
            jsConsole.writeLine( giveSingleNumbers( number ) );
            console.log( giveSingleNumbers( number ) );
        } else if ( number.length === 2 && number < 20 ) {
            jsConsole.writeLine( giveTwoDigitsNumbers( number ) );
            console.log( giveTwoDigitsNumbers( number ) );
        } else if ( number.length === 2 ) {
            tenthsNumbers = Math.floor( number / 10 );
            numbers = number % 10;
            jsConsole.writeLine( giveTenthseNumbers( tenthsNumbers.toString() ) +
                ' ' + giveSingleNumbers( numbers.toString().toLowerCase() ) );
            console.log( giveTenthseNumbers( tenthsNumbers.toString() ) +
                ' ' + giveSingleNumbers( numbers.toString().toLowerCase() ) );
        } else if ( number.length === 3 ) {
            firstNumber = Math.floor( number / 100 );
            secondNumber = Math.floor( number / 10 ) % 10;
            thirdNumber = number % 10;

            if ( secondNumber === 0 && thirdNumber === 0 ) {
                hundredsNumbers = giveHundredsNumbers( firstNumber.toString() );
                jsConsole.writeLine( hundredsNumbers );
                console.log( hundredsNumbers );
            }
            else if ( secondNumber === 0 ) {
                hundredsNumbers = giveHundredsNumbers( firstNumber.toString() );
                numbers = giveSingleNumbers( thirdNumber.toString() ).toLowerCase();
                jsConsole.writeLine( hundredsNumbers + ' and ' + numbers );
                console.log( hundredsNumbers + ' and ' + numbers );
            }
            else if ( thirdNumber === 0 ) {
                hundredsNumbers = giveHundredsNumbers( firstNumber.toString() );
                tenthsNumbers = giveTenthseNumbers( secondNumber.toString() ).toLowerCase();
                jsConsole.writeLine( hundredsNumbers + ' and ' + tenthsNumbers );
                console.log( hundredsNumbers + ' and ' + tenthsNumbers );
            }
            else if ( secondNumber === 1 ) {
                hundredsNumbers = giveHundredsNumbers( firstNumber.toString() );
                numbers = giveTwoDigitsNumbers( thirdNumber.toString() ).toLowerCase();
                jsConsole.writeLine( hundredsNumbers + ' and ' + numbers );
                console.log( hundredsNumbers + ' and ' + numbers );
            }
            else {
                hundredsNumbers = giveHundredsNumbers( firstNumber.toString() );
                tenthsNumbers = giveTenthseNumbers( secondNumber.toString() ).toLowerCase();
                numbers = giveSingleNumbers( thirdNumber.toString() ).toLowerCase();
                jsConsole.writeLine( hundredsNumbers + ' and ' + tenthsNumbers + ' ' + numbers );
                console.log( hundredsNumbers + ' and ' + tenthsNumbers + ' ' + numbers );
            }
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine( '--------------------------------------' );




    function giveSingleNumbers( number ) {
        switch ( number ) {
            case '0':
                number = 'Zero';
                break;
            case '1':
                number = 'One';
                break;
            case '2':
                number = 'Two';
                break;
            case '3':
                number = 'Three';
                break;
            case '4':
                number = 'Four';
                break;
            case '5':
                number = 'Five';
                break;
            case '6':
                number = 'Six';
                break;
            case '7':
                number = 'Seven';
                break;
            case '8':
                number = 'Eight';
                break;
            case '9':
                number = 'Nine';
                break;
            default:
                break;
        }

        return number;
    }

    function giveTwoDigitsNumbers( number ) {
        switch ( number ) {
            case '1':
            case '10':
                number = 'Ten';
                break;
            case '1':
            case '11':
                number = 'Eleven';
                break;
            case '2':
            case '12':
                number = 'Twelve';
                break;
            case '3':
            case '13':
                number = 'Thirteen';
                break;
            case '4':
            case '14':
                number = 'Fourteen';
                break;
            case '5':
            case '15':
                number = 'Fifteen';
                break;
            case '6':
            case '16':
                number = 'Sixteen';
                break;
            case '7':
            case '17':
                number = 'Seventeen';
                break;
            case '8':
            case '18':
                number = 'Eighteen';
                break;
            case '9':
            case '19':
                number = 'Nineteen';
                break;
            default:
                break;
        }

        return number;
    }

    function giveTenthseNumbers( number ) {
        switch ( number ) {
            case '1':
                number = 'Ten';
                break;
            case '2':
                number = 'Twenty';
                break;
            case '3':
                number = 'Thirty';
                break;
            case '4':
                number = 'Fourty';
                break;
            case '5':
                number = 'Fifty';
                break;
            case '6':
                number = 'Sixty';
                break;
            case '7':
                number = 'Seventy';
                break;
            case '8':
                number = 'Eighty';
                break;
            case '9':
                number = 'Ninety';
                break;
            default:
                break;
        }

        return number;
    }

    function giveHundredsNumbers( number ) {
        switch ( number ) {
            case '1':
                number = 'One hundred';
                break;
            case '2':
                number = 'Two hundred';
                break;
            case '3':
                number = 'Three hundred';
                break;
            case '4':
                number = 'Four hundred';
                break;
            case '5':
                number = 'Five hundred';
                break;
            case '6':
                number = 'Six hundred';
                break;
            case '7':
                number = 'Seven hundred';
                break;
            case '8':
                number = 'Eight hundred';
                break;
            case '9':
                number = 'Nine hundred';
                break;
            default:
                break;
        }

        return number;
    }

}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

