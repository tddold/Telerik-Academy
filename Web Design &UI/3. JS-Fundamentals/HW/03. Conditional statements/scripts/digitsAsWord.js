/**
 Problem 5. Digit as word

 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 Examples:

 digit    result
 2    two
 1    one
 0    zero
 5    five
 -0.1    not a digit
 hi    not a digit
 9    nine
 10    not a digit
 */

var i,
	len,
	array = [2, 1, 0, 5, -0.1, 'hi', 9, 10];

for (i = 0, len = array.length; i < len; i+=1) {
    switch (array[i]) {

        case 0:
            console.log('zero');
            break;
        case 1:
            console.log('one');
            break;
        case 2:
            console.log('two');
            break;
        case 3:
            console.log('three');
            break;
        case 4:
            console.log('four');
            break;
        case 5:
            console.log('five');
            break;
        case 6:
            console.log('six');
            break;
        case 7:
            console.log('seven');
            break;
        case 8:
            console.log('eight');
            break;
        case 9:
            console.log('nine');
            break;
        default :
            console.log('not a digit');
            break;
    }
}