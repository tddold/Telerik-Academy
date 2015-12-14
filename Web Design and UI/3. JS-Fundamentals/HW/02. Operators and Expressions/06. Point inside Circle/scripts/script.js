/*
6.Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

*/

function checkInput() {

    var x = jsConsole.readInteger( '#x' ),
        y = jsConsole.readInteger( '#y' );

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    if ( x > 5 || y > 5 ) {
        jsConsole.writeLine( 'The given point (x, y) is not within a circle K(O, 5).' );
    }
    else {
        jsConsole.writeLine( 'The given point (x, y) is within a circle K(O, 5).' );
    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}