/**
 Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 Examples:

 a    b    result
 5    2    2 5
 3    4    3 4
 5.5    4.5    4.5 5.5
 */

var arrayA = [5, 3, 5.5],
    arrayB = [2, 4, 4.5];

for (var i = 0; i < arrayA.length; i++) {
    isGreater(arrayA[i], arrayB[i]);
}

function isGreater(a, b) {
    if (a < b) {
        console.log(a + ' ' + b);
    } else {
        console.log(b + ' ' + a);
    }
}