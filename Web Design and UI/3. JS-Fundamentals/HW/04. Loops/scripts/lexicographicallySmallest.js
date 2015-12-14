/**
 Problem 4. Lexicographically smallest
 Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 4. Lexicographically smallest";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 4. Lexicographically smallest";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.";

    var doc = document,
        win = window,
        navi = navigator;

    printMinAQndMax(doc);
    printMinAQndMax(win);
    printMinAQndMax(navi);

    function printMinAQndMax(obj) {

        var min = 0,
            max = 0;

        for (var property in obj) {
            if (!min) {
                min = property;
            }

            if (!max) {
                max = property;
            }

            if (property < min) {
                min = property;
            }

            if (property > max) {
                max = property;
            }

        }
        jsConsole.writeLine('--------------------------------------');
        jsConsole.writeLine(obj);
        console.log(obj);

        jsConsole.writeLine('min = ' + min);
        console.log('min = ' + min);

        jsConsole.writeLine('max = ' + max);
        console.log('max = ' + max);


        jsConsole.writeLine('--------------------------------------');

    }
}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}