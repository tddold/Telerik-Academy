/*
1. Write an expression that checks if given integer is odd or even. * 
 */

function checkInput() {

    var number = jsConsole.readInteger( '#input' ),
        result = number % 2 === 0 ? 'even' : 'odd';

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );
   
    jsConsole.writeLine( 'Yor number is ' + result );

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}