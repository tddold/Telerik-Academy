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

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Exchange if greater";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.";

    var a = jsConsole.readInteger( '#first' ),
        b = jsConsole.readInteger( '#second' ),
        greater,
        smaller;

    console.log( a );

    if ( a > b ) {
        greater = a;
        smaller = b;
    } else {
        greater = b;
        smaller = a;
    }


    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    jsConsole.writeLine( 'Result is: ' + smaller + ' ' + greater);

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}

//Problem 2. Multiplication Sign

//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	b	c	result
//5	2	2	+
//-2	-2	1	+
//-2	4	3	-
//0	-2.5	4	0
//-1	-0.5	-5.1	-

function task2() {

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Multiplication Sign";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.";

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

   

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}



function task3() {

    
   

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

}



function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Conditional statements!";
    jsConsole.clearConsole();
}