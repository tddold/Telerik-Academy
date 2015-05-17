/*
2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
*/

function checkInput() {

    var number = jsConsole.readInteger( '#input' ),
        result = ( ( number % 5 === 0 ) && ( number % 7 === 0 ) ) ? 'Yes' : 'No',
        sequensResult;   

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );
   
    jsConsole.writeLine( 'This number is divided by 5 and 7: ' + result );

    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    for ( var i = 1; i < 100; i++ ) {
        if ( i % 5 === 0 && i % 7 === 0 ) {
            jsConsole.writeLine( 'The numbers 1-100 are divided into 5 and 7 are: ' + i );
        }
    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}