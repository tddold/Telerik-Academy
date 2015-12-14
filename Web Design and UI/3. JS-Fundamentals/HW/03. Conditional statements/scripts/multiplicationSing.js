/**
 Problem 2. Multiplication Sign

 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 Examples:

 a    b    c    result
 5    2    2    +
 -2    -2    1    +
 -2    4    3    -
 0    -2.5    4    0
 -1    -0.5    -5.1    -
 */

var i,
    len,
    arrayA = [5, -2, -2, 0, -1],
    arrayB = [2, -2, 4, -2.5, -0.5],
    arrayC = [2, 1, 3, 4, -5.1];

for (i = 0, len = arrayA.length; i < len; i+=1) {
    checkSing(arrayA[i], arrayB[i], arrayC[i]);
}


function checkSing(a, b, c) {
    if (a === 0 || b === 0 || c === 0) {
        console.log('Result is: "0"');
    } else if (a < 0 && b < 0 && c < 0) {
        console.log('Result is: "-"');
    } else if (a < 0 && (b > 0 && c > 0) ||
               b < 0 && (a > 0 && c > 0) ||
               c < 0 && (a > 0 && b > 0)) {
        console.log('Result is: "-"');
    } else {
        console.log('Result is: "+"');
    }
}