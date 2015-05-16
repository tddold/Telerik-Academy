/*1. Assign all the possible JavaScript literals to different variables.*/

alert('Press F12 -> Open Console Tab');

// numbers
var a = 10;
var b = 5;
var sum = a + b;
var integer = 5;
var float = 1.5;
var pi = Math.PI;
var minValue = Number.MIN_VALUE;
var maxValue = Number.MAX_VALUE;

/*Boolean*/
var bool = true;
var greaterAB = (a < b);

/*Strings*/
var strVarible = 'Hello, JS!';

/*Undefined value*/
var undef = undefined;

/*Null value*/
var nulable = null;

/*Array*/
var array = ['string', 5.6, 3, { Name: 'JS', Cource: 'Fundamentals', Lecture: 2 }];

/*Object*/
var obj = {
    Name: 'JS',
    Cource: 'Fundamentals',
    Lecture: 2
};


console.log('integer = ' + a + '\t\t\t\t\t\t\t\t - This is:' + typeof (a) + '\n' +
            'integer = ' + sum + '\t\t\t\t\t\t\t\t - This is:' + typeof (sum) + '\n' +
            'Floating-Point = ' + float + '\t\t\t\t\t\t - This is:' + typeof (float) + '\n' +
            'Floating-Point -> Pi = ' + pi + '\t - This is:' + typeof (pi) + '\n' +
            'Min Value = ' + minValue + '\t\t\t\t\t\t\t - This is:' + typeof (minValue) + '\n' +
            'Max Value = ' + maxValue + '\t\t\t - This is:' + typeof (maxValue) + '\n' +
            'Boolean value -> ' + bool + '\t\t\t\t\t\t - This is:' + typeof (bool) + '\n' +
            'Boolean value -> %s', greaterAB + '\t\t\t\t\t\t - This is:' + typeof (greaterAB) + '\n' +
            'String literal -> ', strVarible + '\t\t\t\t - This is:' + typeof (strVarible) + '\n' +
            'Undefined value -> ' + undef + '\t\t\t\t - This is:' + typeof (undef) + '\n' +
            'Nulable value -> ' + nulable + '\t\t\t\t\t\t - This is:' + typeof (nulable) + '\n' +
            'Array -> ' + array + '\t\t - This is:' + typeof (array) + '\n' +
            'Object -> ' + obj + '\t\t\t\t\t - This is:' + typeof (obj) + '\n');