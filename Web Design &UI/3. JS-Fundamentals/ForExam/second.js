//------------------------------------------------------------------------
var list = '',
	i;
for (i = 0; i < 26; ++i){
 list += String.fromCharCode(i + 65);
}
//create charArray from english alphabet
//=========================================================================================

console.log(list);
console.log(isLetter('c'));
console.log(isDigit('c'));
console.log(returnDigitsFromString('c'));
console.log(makeMatrixOfStrings(['a', 'b', 'c', 'd', 'e', 'f', 'g']));




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