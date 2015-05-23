/*Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 Examples:

 a	     b	     c	     biggest
 5	     2	     2	     5
 -2	    -2	     1	     1
 -2	     4	     3	     4
 0	    -2.5	 5	     5
 -0.1	-0.5	-1.1	-0.1*/

var arrayA = [5, -2, -2, 0, -0.1],
    arrayB = [2, -2, 4, -2.5, -0.5],
    arrayC = [2, 1, 3, -2.5, -1.1];

for (var i = 0; i < arrayA.length; i++) {
    console.log('Biggest number is: ' + isBiggest(arrayA[i], arrayB[i], arrayC[i]));
}

function isBiggest(a, b, c) {
    if (a > b) {
        if (a > c) {
            return a;
        } else {
            return c;
        }
    } else {
        if (b > c) {
            return b;
        } else {
            return c;
        }
    }
}