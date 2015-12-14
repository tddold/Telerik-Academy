/*
 Problem 4. Sort 3 numbers

 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.

 Examples:

 a	     b	     c	      result
 5	     1	     2	      5     2     1
 -2	    -2	     1	      1    -2    -2
 -2	     4	     3	      4     3    -2
 0	    -2.5	 5	      5     0    -2.5
 -1.1	-0.5	-0.1	 -0.1  -0.5  -1.1
 10	    20	    30	     30    20    10
 1	     1	     1	      1     1     1
 */

var i,
    len,
    arrayA = [5, -2, -2, 0, -1.1, 10, 1],
    arrayB = [1, -2, 4, -2.5, -0.5, 20, 1],
    arrayC = [2, 1, 3, 5, -0.1, 30, 1];

for (i = 0, len = arrayA.length; i < len; i+=1) {
    console.log('Result is: ' );
    isSorted(arrayA[i], arrayB[i], arrayC[i]);
    console.log('');
}

function isSorted(a, b, c) {
    if (a > b) {
        if (a > c) {
            if (b > c) {
                console.log(a + ' ' + b + ' ' + c);
            } else {
                console.log(a + ' ' + c + ' ' + b);
            }
        } else {
            console.log(c + ' ' + a + ' ' + b);
        }
    } else {
        if (b > c) {
            if (a > c) {
                console.log(b + ' ' + a + ' ' + c);
            } else {
                console.log(b + ' ' + c + ' ' + a);
            }
        } else {
            console.log(c + ' ' + b + ' ' + a);
        }
    }
}