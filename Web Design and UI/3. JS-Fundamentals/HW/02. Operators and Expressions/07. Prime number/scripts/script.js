/*
7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
*/

function checkInput() {

    var number = jsConsole.readInteger( '#input' ),
        isTrue = true;


    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );


    if ( number > 1 && number <= 100 ) {

        for ( var i = 2; i <= 10; i++ ) {

            if ( number != i ) {

                if ( number % i === 0 ) {
                    isTrue = false;
                }
            }
        }

        jsConsole.writeLine( 'The number is primr! --> ' + isTrue );

    }
    else {
        jsConsole.writeLine( 'The number is out of range. Must be between 1-100!' );
    }
    

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}