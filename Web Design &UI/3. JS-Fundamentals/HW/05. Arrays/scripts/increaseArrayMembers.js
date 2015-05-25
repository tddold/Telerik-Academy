/**
 Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the consol
 */

function task1(){
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 1. Increase array members";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 1. Increase array members";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.";

    var array = [];

    jsConsole.writeLine('--------------------------------------');


    for (var i = 0; i < 20; i++) {
        array[i] = i*5;
        if (i < 19) {
            jsConsole.write(array[i] + ', ')
        }   else{
            jsConsole.write(array[i])

        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');

}
