/**
 Problem 6. Quadratic equation

 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.

 Examples:

 a    b    c    roots
 2    5    -3    x1=-3; x2=0.5
 -1    3    0    x1=3; x2=0
 -0.5    4    -8    x1=x2=4
 5    2    8    no real roots
 */

var i,
    len,
    arrayA = [2, -1, -0.5, 5],
    arrayB = [5, 3, 4, 2],
    arrayC = [-3, 0, -8, 8];

for ( i = 0, len=arrayA.length; i < len; i+=1) {
    quadraticEquations(arrayA[i], arrayB[i], arrayC[i]);
}

function quadraticEquations(a, b, c) {
    var d,
        x,
        x1,
        x2;

    d = b * b - 4 * a * c;

    if (d < 0) {
        console.log('no real roots');
    } else if (d === 0) {
        x = -b / (2 * a);
        console.log('x1 = x2= ' + x);
    } else {
        x1 = (-b - Math.sqrt((b * b) - (4 * a * c))) / (2 * a);
        x2 = (-b + Math.sqrt((b * b) - (4 * a * c))) / (2 * a);
        console.log('x1 = ' + x1 + '; ' + 'x2 = ' + x2);
    }
}
