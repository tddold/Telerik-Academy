/**
 Problem 1. Numbers
 Write a script that prints all the numbers from 1 to N.
 */

function task1() {
    jsConsole.clearConsole();
    document.getElementsByTagName("h2")[0].innerHTML = "Problem 1. Numbers";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 1. Numbers";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that prints all the numbers from 1 to N.";

    var i,
        n = 100;
    jsConsole.writeLine('--------------------------------------');
    for ( i = 1; i <= n; i++) {
        if (i < n) {
            jsConsole.write(i + ',');

        } else {
            jsConsole.write(i);
        }
        console.log(i);
    }

    jsConsole.writeLine('');
    jsConsole.writeLine('--------------------------------------');

}
