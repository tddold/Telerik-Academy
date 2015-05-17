/*
4. Write an expression that checks for given integer if its third digit (right-to-left) is 7.
E. g. 1732 -> true.

*/

function checkInput() {

    var number = jsConsole.readInteger( '#input' ),
        result = parseInt(number / 100) % 10;



    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );
   

    if ( result === 7 ) {
        jsConsole.writeLine( 'The third digits is 7  on number ' + number + ': Yes' );

    }
    else {
        jsConsole.writeLine( 'Third digits of the number ' + number + ' is 7: No' );

    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}