/**
 Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */

function task2() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 2. Lexicographically comparison";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 2. Lexicographically comparison";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that compares two char arrays lexicographically (letter by letter).";


    var arrayA = 'Hello'.split(''),
        arrayB = 'Hello'.split('');

    jsConsole.writeLine('--------------------------------------');
    jsConsole.writeLine('Array A: [' + arrayA + ']');
    console.log(arrayA);

    jsConsole.writeLine('Array B: [' + arrayB + ']');
    console.log(arrayB);

    compareArray(arrayA, arrayB);

    jsConsole.writeLine('--------------------------------------');
}

function compareArray(arrayA, arrayB) {
    var equalArray;

    for (var i = 0; i < Math.min(arrayA.length, arrayB.length); i++) {
        if (arrayA[i] !== arrayB[i]) {
            arrayA < arrayB ? jsConsole.writeLine('Array A is smallest.') : jsConsole.writeLine('Array B is smallest.');
            arrayA < arrayB ? equalArray = -1 : equalArray = 1;
            break;
        } else {
            equalArray = 0;
        }
    }
    jsConsole.writeLine();


    if (equalArray === 0) {
        jsConsole.writeLine('Both array are equals.');
    } else if (equalArray === -1) {
        jsConsole.writeLine('Array A is smallest.');
    } else {
        jsConsole.writeLine('Array B is smallest.');
    }
}

function clearCon() {
    document.getElementsByTagName("h2")[0].innerHTML = "";
    document.getElementsByTagName("p")[0].innerHTML = "";
    document.getElementsByTagName("p")[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}
