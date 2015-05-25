/**
 Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */

function task4() {
    jsConsole.clearConsole();
    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 2. Numbers not divisible";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 2. Numbers not divisible";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time";

    var n = 100;
    jsConsole.writeLine('--------------------------------------');

    for (var i = 1; i <= n; i++) {

        if (!(i % 3 === 0 && i % 7 === 0)) {
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