/**
 Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 Examples:

 a    b    c    d    e    biggest
 5    2    2    4    1    5
 -2    -22    1    0    0    1
 -2    4    3    2    0    4
 0    -2.5    0    5    5    5
 -3    -0.5    -1.1    -2    -0.1    -0.1
 */

var arrayA = [5, -2, -2, 0, -3],
    arrayB = [2, -22, 4, -2.5, -0.5],
    arrayC = [2, 1, 3, 0, -1.1],
    arrayD = [4, 0, 2, 5, -2],
    arrayE = [1, 0, 0, 5, -0.1];

for (var i = 0; i < arrayA.length; i++) {
    isBiggest(arrayA[i], arrayB[i], arrayC[i], arrayD[i], arrayE[i]);
}

function isBiggest(a, b, c, d, e) {
    if (a > b) {
        if (a > c) {
            if (a > d) {
                if (a > e) {
                    console.log('Biggest is: ' + a);
                } else {
                    console.log('Biggest is: ' + e);
                }
            } else {
                if (d > e) {
                    console.log('Biggest is: ' + d);
                } else {
                    console.log('Biggest is: ' + e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    console.log('Biggest is: ' + c);
                } else {
                    console.log('Biggest is: ' + e);
                }
            } else {
                if (d > e) {
                    console.log('Biggest is: ' + d);
                } else {
                    console.log('Biggest is: ' + e);
                }
            }
        }
    } else {
        if (b > c) {
            if (b > d) {
                if (b > e) {
                    console.log('Biggest is: ' + b);
                } else {
                    console.log('Biggest is: ' + e);
                }
            } else {
                if (d > e) {
                    console.log('Biggest is: ' + d);
                } else {
                    console.log('Biggest is: ' + e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    console.log('Biggest is: ' + c);
                } else {
                    console.log('Biggest is: ' + e);
                }
            } else {
                if (d > e) {
                    console.log('Biggest is: ' + d);
                } else {
                    console.log('Biggest is: ' + e);
                }
            }
        }
    }
}
