/**
 Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers
 */
function task3(){
    jsConsole.clearConsole();

    document.getElementsByTagName( "h2" )[0].innerHTML = "Problem 3. Min/Max of sequence";
    document.getElementsByTagName( "p" )[1].innerHTML = "Problem 3. Min/Max of sequence";
    document.getElementsByTagName( "p" )[0].innerHTML = "Write a script that finds the max and min number from a sequence of numbers.";

    var array = [5, 3, 2, 6, 4, 9, 7, 8],
        minNumber = Number.MAX_VALUE,
        maxNumber = Number.MIN_VALUE;

    for (var i = 0; i < array.length; i++) {
        if (array[i] < minNumber) {
            minNumber = array[i];
        } else if (array[i] > maxNumber) {
            maxNumber = array[i];
        }
    }

    jsConsole.writeLine('--------------------------------------');

    jsConsole.writeLine('Min number of sequence is: ' + minNumber);
    console.log('Min number of sequence is: ' + minNumber);

    jsConsole.writeLine('Max number of sequence is: ' + maxNumber);
    console.log('Max number of sequence is: ' + maxNumber);

    jsConsole.writeLine('--------------------------------------');

}

function clearCon() {
    document.getElementsByTagName( "h2" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[0].innerHTML = "";
    document.getElementsByTagName( "p" )[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

