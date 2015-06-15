var test1 =[],
	test2 =[],
	separator ;

separator = new Array(16).join('-');

function solve (input) {
	var len = input.length;

}

console.log(solve(test1));

console.log(separator); // ----------------

console.log(solve(test2));


/*
2. При задачите със стрингове е хубаво да се прави trim() колкото е възможно по-често или още в началото един цял replace на всички multiwhite-spaces с един:
*/
var string = '     pesho       go    sho';


string = string.replace(/  +/g, ' ');

console.log('\n2. Trim! \n' + separator ); // ----------------
console.log(string); // pesho go sho

/*
3. Превръщане на стрингово число в number число: '21' * 1 = 21;
*/

console.log('\n3. String to number! \n' + separator ); // ----------------
var str = '21';
console.log(str + ' -> ' + typeof(str));


str = +str; // str = str *1, parseInt(str), Number(str), Math.floor(str), str|0
console.log('\n' + str + ' -> ' + typeof(str));


/*
4. Да се внимава, ако в задачата има няколко for цикъла, да се използва i, j , k, m... да не се използва повторно i примерно, че може да стане мазало от горния for цикъл :)
5. Да се внимава и със търсенето на мин и макс. На първоначалните стойности да се присвояват +Infinity и -Infinity, че MIN_VALUE и MAX_VALUE не са типичните мин и макс валюта :) (виж. лекциите).
*/

console.log('\n5. Min, Max! \n' + separator ); // ----------------

var min = -Infinity;
console.log(min);

var max = +Infinity;
console.log(max);


/*
6. При обхождане на матрица, и ако се опитаме да вземем matrix[i+1][j+1], ако i+1 не съществъва (i + 1 === undefined), то ще гръмне, и аз лично съм се чудил 5 часа защо гърми :) изводът е първо да се провери дали i+1 съществува :)
7. Да се избягват Math... blah blah blah.. че са много бавни и може bgcoder да гръмне за време. Има си алтернативи. Math.floor == 22.3 | 0 (22). Math.pow == един for цикъл.
*/

console.log('\n7. Parse int! \n' + separator); // ----------------

var num = Math.floor(22.3);
console.log(num);

num = 22.3;
num = 22.3 |0;
console.log(num);

console.log(22.2|1);
/*
8. При стринговите задачи да се ползва автомат (символ по символ да се гледа и да се правят 15 хиляди if). (Задачите със стрингове могат и да се решават с парсване, но може да стане голямо мазало там) (Надявам се трейнърите да се смилят и да дадат малко по-не толкова завъртяни задачи, и да могат да се решават на части, примерно).
9. И може би най-важното за мен: да се проверява почти всеки ред дали ти изкарва това, което ти искаш, чрез проверяване с различни примери. Step by step :)
10. <good></luck>
*/

/*
11. array.sort() не сортира числа като числа, а като стрингове.
За това :*/
var array = [5,2,1,3,4];


array.sort(function(a, b) {return (a - b)});

console.log('\n11. Sort! \n' + separator); // ----------------

console.log(array);


/*
12. Да си направим една функция за проверка на числа : 
*/
console.log('\n11. Check is number! \n' + separator); // ----------------

var string = '11',
	number = 12;

	console.log(isNumber(string));

	console.log(isNumber(number));

function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

console.log(isFinite('5') + ' -> ' + typeof(isFinite('5')));
console.log(isFinite('c')+ ' -> ' + typeof(isFinite('5')));

console.log(parseFloat('5') + ' -> ' + typeof(parseFloat('5')));
console.log(parseFloat('c')+ ' -> ' + typeof(parseFloat('5')));


/*
13. Пълнене на двумерен масив(матрица) :
*/

var row,
	col,
	count = 1,
	rows = 5,
	cols = 5,
	matrix = [];

for(row = 0; row < rows; row += 1) {
     matrix.push( [] );
      for ( col = 0; col < cols; col += 1){
           matrix[row][col] = count;
           count += 1;
     }
}

    console.log(matrix);


/*
14. Ако искаме да копираме масив и новия да не е с референция към стария ,а да е изцяло нов:
*/
var numbers = [5, 6, 7, 8, 9];
var copy = numbers.slice();
numbers[1] = 100;
console.log(numbers); // [5,100,7,8,9];
console.log(copy); // [5,6,7,8,9];

//==========================================================================================

function removeTags(text) {
	var wordsBetweenTags='';
	for (var j = 0; j < text.length; j++) {
		var indexStart = text.indexOf('<');
		var indexEnd = text.indexOf('>');
		text = (text.replace(text.substring(indexStart, indexEnd + 1),''));// trii tagovete
	}
	return  text;
}

function getTagName(text) {
	var tagName='';
	for (var i = 0; i < text.length; i++) {
		var indexStart = text.indexOf('>');
		var indexEnd = text.indexOf('<');
		tagName = text.substring(indexStart, indexEnd + 1);   //return the text between tags
	}
	return tagName;
}

function textBetweenTags(text) {
	var textBetweenTags='';
	for (var i = 0; i < text.length; i++) {
		var indexStart = text.indexOf('>');
		var indexEnd = text.indexOf('</');
		textBetweenTags = text.substring(indexStart+1, indexEnd );
	}
	return textBetweenTags;
}

function convertWordUpcaseAndLowcase(text) {
	text=text.split('');
	var word='';
	for (var i =0;i<text.length;i++) {
		if (i%2===0) {
			word+= text[i].toUpperCase();
		}
		else {
			word += text[i];
		}
	}
	return word;
}

function countStringOccuranceInText(text, pattern) { //Broi vsichki savpadenia na tyrsenia string bez znachenie sliato ili ne
	text = text.toLowerCase();
	var count = 0;
	for (var i = 0; i < text.length; i++) {
		text = text.replace(pattern, "*");
		if (text[i] === '*') {
			count++;
		}
	}
	return count;
}
//------------------------------------------------------------------------
var list = '';
for (var i = 0; i !== 26; ++i) list += String.fromCharCode(i + 65);
//create charArray from english alphabet
//=========================================================================================


function isLetter(symbol) {
	var asciiCode = symbol.charCodeAt(0);
	if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
		return true;
	}
	return false;
}

function isDigit(symbol) {
	var asciiCode = symbol.charCodeAt(0);
	if (asciiCode > 47 && asciiCode < 58)  {
		return true;
	}
	return false;
}

function returnDigitsFromString(string) {
	function isDigit(string) {
		var result=isFinite(string);
		return result;
	}
	function keepOnlyDigitsinString(string) {
		var number = '';
		for (var i = 0; i < string.length; i += 1) {
			if (isDigit(string[i])) {
				number += parseInt(string[i], 10);
			}
		}
		number = number.replace(' ', '');
		return number;
	}
	return keepOnlyDigitsinString(string);
}
//=================================================================================
//Matrix of strings
function makeMatrixOfStrings(arrayOfStrings) {
	var matrix = [];
	arrayOfStrings.forEach(function(string) {
		matrix.push(string.toLowerCase().split(''));
	});
	console.log(matrix);
}

//----------------------------------------------------------------------
//Matrix of Numbers in format:  123
                                456
function createMatrix(string) {
	var rowCol = string[0].split(' ').map(Number);
	var row = rowCol[0];
	var col = rowCol[1];
	var matrix = [];
	var counter = 1;
	for (var i = 0; i < row; i+=1) {
		matrix[i] = [];
		for (var j = 0; j < col; j+=1) {
			matrix[i][j] = counter++;
		}
	}
	return matrix;
}
