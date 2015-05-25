/**
 Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 Example:
 input                            result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1    2, 2, 2

 */
function task3() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 3. Maximal sequence";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 3. Maximal sequence";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that finds the maximal sequence of equal elements in an array.";

    var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
        count = 1,
        maxSequence = 0,
        number;

    for (var i = 1; i < array.length; i++) {
        if (array[i] === array[i - 1]) {
            count++;
        } else {
            if (count > maxSequence) {
                maxSequence = count;
                number = array[i - 1];
            }
            count = 1;
        }
    }

    jsConsole.writeLine('--------------------------------------');


    for (var i = 0; i < maxSequence; i++) {
        if (i < maxSequence - 1) {
            jsConsole.write(number + ', ');
            console.log(number + ', ');
        } else {
            jsConsole.write(number);
            console.log(number);
        }
    }
    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');

}

function clearCon() {
    document.getElementsByTagName("h2")[0].innerHTML = "";
    document.getElementsByTagName("p")[0].innerHTML = "";
    document.getElementsByTagName("p")[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

