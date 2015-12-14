/**
 Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */

function task2() {
    jsConsole.clearConsole();
    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Numbers not divisible";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Numbers not divisible";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time";

    var i,
        n = 100;
    jsConsole.writeLine('--------------------------------------');

    for (i = 1; i <= n; i++) {

        if (!(!(i % 3) && !(i % 7))) {
            if (i < n) {
                jsConsole.write(i + ',');
            } else {
                jsConsole.write(i);
            }

            console.log(i);
        }
    }

    jsConsole.writeLine('');

    jsConsole.writeLine('--------------------------------------');
}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}