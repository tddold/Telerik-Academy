/*
5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


*/

function checkInput() {

    var number = jsConsole.readInteger( '#input' ),
        mask = 1,
        result = number >> 2;

        result = result & mask;



    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );


    if ( result === 1 ) {
        jsConsole.writeLine( 'The third bit is 1.' );

    }
    else {
        jsConsole.writeLine( 'The third bit is 0.' );

    }

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}