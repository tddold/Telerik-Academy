/*
9.Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

function checkInput() {

    var x = jsConsole.readFloat( '#x' ),
        y = jsConsole.readFloat( '#y' );

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );


    jsConsole.writeLine( 'Point inside a circle & outside of a rentangle!' );

    if ( (((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= (1.5 * 1.5)) {
        if ( y > 1 ) {
            jsConsole.writeLine( 'Yes' );

        }
        else {
            jsConsole.writeLine( 'No' );

        }
    }
    else {
        jsConsole.writeLine( 'No' );

    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}