/*
8.Write an expression that calculates trapezoid's area by given sides a and b and height h.

*/

function checkInput() {

    var a = jsConsole.readFloat( '#a' ),
        b = jsConsole.readFloat( '#b' ),
        h = jsConsole.readFloat( '#h' );


    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    jsConsole.writeLine( 'The trapezoid\'s area is --> ' + ((a + b) * h) / 2 );

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}