/*2. Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.*/

//alert( 'Press F12 -> Open Console Tab' );

/*Strings*/
var strVarible = '"How you doin ?", Joey said.';

function stringVariable() {

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );

    jsConsole.writeLine(strVarible);
    

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}


console.log( 'String variable with quoted text -> ', strVarible + '\t\t\t\t - This is:' + typeof ( strVarible ) );