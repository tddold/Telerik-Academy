/*
3.Write an expression that calculates rectangle’s area by given width and height.
*/

function checkInput() {

    var width = jsConsole.readInteger( '#width' ),
        height = jsConsole.readInteger( '#height' ),
        result = width * height;   

    jsConsole.writeLine();
    jsConsole.writeLine( "---------------------------------------------------------------------------" );
   
    jsConsole.writeLine( 'Area of the rectangle is: ' + result );

    jsConsole.writeLine( "---------------------------------------------------------------------------" );
}