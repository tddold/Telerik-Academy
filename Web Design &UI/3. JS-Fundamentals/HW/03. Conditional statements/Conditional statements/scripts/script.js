/*Conditional statements*/

/*Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
Examples:

a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5*/




function task1() {
    jsConsole.clearConsole();
    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.";

    var a = jsConsole.readInteger( '#first' ),
        b = jsConsole.readInteger( '#second' ),
        greater,
        smaller;

    //var input = document.createElement("input");
    //input.type = "text";
    //input.className = "css-class-name"; // set the CSS class
    //container.appendChild(input); // put it into the DOM

    // //document.body.insertBefore(createElement, container);    

    if ( a > b ) {
        greater = a;
        smaller = b;
    } else {
        greater = b;
        smaller = a;
    }


    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    jsConsole.writeLine( 'Result is: ' + smaller + ' ' + greater );
    console.log( 'Result is: ' + smaller + ' ' + greater );

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}

//Problem 2. Multiplication Sign

//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

// a	 b	    c	    result
// 5     2	    2	    +
//-2	-2	    1	    +
//-2	 4	    3	    -
// 0  -2.5	    4	    0
//-1  -0.5	 -5.1	    -

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.";

    var a = jsConsole.readFloat( "#first" ),
        b = jsConsole.readFloat( '#second' ),
        c = jsConsole.readFloat( '#third' ),
        minus = false,
        plus = true,
        zero = false;

    if ( a === 0 || b === 0 || c === 0 ) {
        zero = true;
        plus = false;

    } else if ( ( a < 0 && b < 0 && c < 0 ) ||
         ( ( a < 0 && ( b > 0 && c > 0 ) || ( b < 0 && ( a > 0 && c > 0 ) ) || ( c < 0 && ( b > 0 && a > 0 ) ) ) ) ) {
        minus = true;
        plus = false;
    }


    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );


    if ( plus ) {
        jsConsole.writeLine( 'Result is: "+"' );

    } else if ( minus ) {
        jsConsole.writeLine( 'Result is: "-"' );

    } else if ( zero ) {
        jsConsole.writeLine( 'Result is: 0' );

    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}

//Problem 3. The biggest of Three

//Write a script that finds the biggest of three numbers.
//Use nested if statements.
//    Examples:

//  a	    b	    c	    biggest
//  5	    2	    2	    5
// -2	    -2	    1	    1
// -2	    4	    3	    4
//  0	    -2.5	5	    5
// -0.1	    -0.5	-1.1	-0.1

function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. The biggest of Three";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. The biggest of Three";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the biggest of three numbers. Use nested if statements.";

    var a = jsConsole.readFloat( "#first" ),
        b = jsConsole.readFloat( '#second' ),
        c = jsConsole.readFloat( '#third' ),
        minus = false,
        plus = true,
        zero = false;



    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );



    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}

function task4() {
    jsConsole.clearConsole();

    switch ( switch_on ) {
        case 1: Console.log( 'message' ); break;
        default:

    }
}



function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Conditional statements!";
    jsConsole.clearConsole();
}