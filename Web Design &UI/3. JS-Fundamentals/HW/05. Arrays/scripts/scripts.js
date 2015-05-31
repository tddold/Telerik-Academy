/**
 Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the consol
 */

function task1() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 1. Increase array members";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 1. Increase array members";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.";

    var i,
    	n = 20,
    	array = [];

    jsConsole.writeLine('--------------------------------------');


    for ( i = 0; i < n; i+=1) {
        array[i] = i * 5;
        if (i < 19) {
            jsConsole.write(array[i] + ', ');
            console.log(array[i] + ', ');
        } else {
            jsConsole.write(array[i]);
            console.log(array[i]);
        }
    }

    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');

}


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
    var i,
    	equalArray,
    	maxLenghtArray = Math.min(arrayA.length, arrayB.length);

    for ( i = 0; i < maxLenghtArray; i+=1) {
        if (arrayA[i] !== arrayB[i]) {
            arrayA < arrayB ? jsConsole.writeLine('Array A is smallest.') : jsConsole.writeLine('Array B is smallest.');
            arrayA < arrayB ? equalArray = -1 : equalArray = 1;
            break;
        } else {
            equalArray = 0;
        }
    }
    jsConsole.writeLine();


    if (!equalArray) {
        jsConsole.writeLine('Both array are equals.');
    } else if (equalArray === -1) {
        jsConsole.writeLine('Array A is smallest.');
    } else {
        jsConsole.writeLine('Array B is smallest.');
    }
}

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

    var i,
    	len,
        number,
        count = 1,
        maxSequence = 0,
    	array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

    for ( i = 1, len=array.length; i < len; i+=1) {
        if (array[i] === array[i - 1]) {
            count+=1;
        } else {
            if (count > maxSequence) {
                maxSequence = count;
                number = array[i - 1];
            }
            count = 1;
        }
    }

    jsConsole.writeLine('--------------------------------------');


    for ( i = 0; i < maxSequence; i+=1) {
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


/**
 Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 Example:

 input    result
 3, 2, 3, 4, 2, 2, 4    2, 3, 4
 */

function task4() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 4. Maximal increasing sequence";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 4. Maximal increasing sequence";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that finds the maximal increasing sequence in an array.";

    var array = [3, 2, 3, 4, 2, 2, 4],
    	tmp = [array[0]],
        maxIncreasSequence = [array[0]];

    jsConsole.writeLine('--------------------------------------');

    jsConsole.write(maxIncreasingSequence(array).join(', '));
    console.log(maxIncreasingSequence(array).join());

    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');

    function maxIncreasingSequence(array) {
    	var i,
    		len;

        for ( i = 1, len = array.length; i < len; i+=1) {
            if (array[i] === array[i - 1] + 1) {
                tmp.push(array[i]);
            } else {
                tmp = [array[i]];
            }

            if (tmp.length > maxIncreasSequence.length) {
                maxIncreasSequence = tmp;
            }
        }

        return maxIncreasSequence;
    }
}

/**
 Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */

function task5() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 5. Selection sort";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 5. Selection sort";
    document.getElementsByTagName("p")[0].innerHTML = "Sorting an array means to arrange its elements in increasing order." +
        " Write a script to sort an array." +
        " Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.        Hint: Use a second array";

    var array = [3, 2, 5, 4, 1, 9, 7, 6, 8],
        tmp = [array[0]];

    jsConsole.writeLine('--------------------------------------');

    jsConsole.write(getSelectionSort(array).join(', '));
    console.log(getSelectionSort(array).join());

    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');

    function getSelectionSort(array) {
    	var i,
    		len;

        for ( i = 0, len = array.length; i < len - 1; i += 1) {
            for (var j = i; j < len; j += 1) {
                if (array[i] > array[j]) {
                    tmp = [array[i]];
                    array[i] = array[j];
                    array[j] = tmp[0];
                }
            }
        }

        return array;
    }
}

/**
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 Example:

 input    result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3    4 (5 times)
 */

function task6() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 6. Most frequent number";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 6. Most frequent number";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that finds the most frequent number in an array.";

    var tmp,
        number,
        count = 1,
        maxCount = 0,     
    	array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
       

    getMostFrequentNumber(array);

    function getMostFrequentNumber(array) {
    	var i,
    		len;

        for ( i = 1, len = array.length; i < len - 1; i += 1) {
            tmp = array[i];

            for (var j = i; j < len; j += 1) {
                if (tmp === array[j]) {
                    count+=1;
                }
            }


            if (maxCount < count) {
                maxCount = count;
                number = tmp;
            }

            count = 1;
        }

        jsConsole.writeLine('--------------------------------------');

        jsConsole.write(number + ' (' + maxCount + ' times)');
        console.log(number + ' (' + maxCount + ' times)');

        jsConsole.writeLine();
        jsConsole.writeLine('--------------------------------------');

    }
}


/**
 Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

function task7() {
    jsConsole.clearConsole();

    document.getElementsByTagName("h2")[0].innerHTML = "Problem 7. Binary search";
    document.getElementsByTagName("p")[1].innerHTML = "Problem 7. Binary search";
    document.getElementsByTagName("p")[0].innerHTML = "Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.";

    var mindIndex,
        minIndex = 0,
        findNumber = 3,
    	array = [3, 2, 5, 4, 1, 9, 7, 6, 8],
        maxIndex = array.length - 1;


    array.sort();

    jsConsole.writeLine('--------------------------------------');

    jsConsole.write('The index of given element in a sorted array is: ' + getBinarySearch(array));
    console.log('The index of given element in a sorted array is: ' + getBinarySearch(array));

    jsConsole.writeLine();
    jsConsole.writeLine('--------------------------------------');


    function getBinarySearch(array) {

        while (maxIndex >= minIndex) {
            mindIndex = (minIndex + maxIndex) / 2 | 0;

            if (array[mindIndex] === findNumber) {
                return mindIndex;

            } else if (array[mindIndex] < findNumber) {
                minIndex = mindIndex + 1;
            } else if (array[mindIndex] > findNumber) {
                maxIndex = mindIndex - 1;
            }
        }

        return 'Number not found';

    }
}

function clearCon() {
    document.getElementsByTagName("h2")[0].innerHTML = "";
    document.getElementsByTagName("p")[0].innerHTML = "";
    document.getElementsByTagName("p")[1].innerHTML = "Loops!";
    jsConsole.clearConsole();
}

