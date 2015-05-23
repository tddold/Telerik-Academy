/**
 Problem 8. Number as words

 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 Examples:

 numbers    number as words
 0    Zero
 9    Nine
 10    Ten
 12    Twelve
 19    Nineteen
 25    Twenty five
 98    Ninety eight
 98    Ninety eight
 273    Two hundred and seventy three
 400    Four hundred
 501    Five hundred and one
 617    Six hundred and seventeen
 711    Seven hundred and eleven
 999    Nine hundred and ninety nine
 */

var array = [0, 9, 10, 12, 19, 25, 98, 98, 273, 400, 501, 617, 711, 999],
    firstNumber,
    secondNumber,
    thirdNumber,
    hundredsNumbers,
    tenthsNumbers,
    numbers;

for (var i = 0; i < array.length; i++) {
    checkNumber(array[i].toString());
}

function checkNumber(number) {
    if (number.length === 1) {
        console.log(giveSingleNumbers(number));
    } else if (number.length === 2 && number < 20) {
        console.log(giveTwoDigitsNumbers(number));
    } else if (number.length === 2) {
        tenthsNumbers = Math.floor(number / 10);
        numbers = number % 10;
        console.log(giveTenthseNumbers(tenthsNumbers.toString()) +
            ' ' + giveSingleNumbers(numbers.toString().toLowerCase()));
    } else if (number.length === 3) {
        firstNumber = Math.floor(number / 100);
        secondNumber = Math.floor(number / 10) % 10;
        thirdNumber = number % 10;

        if (secondNumber === 0 && thirdNumber === 0) {
            hundredsNumbers = giveHundredsNumbers(firstNumber.toString());
            console.log(hundredsNumbers);
        }
        else if (secondNumber === 0) {
            hundredsNumbers = giveHundredsNumbers(firstNumber.toString());
            numbers = giveSingleNumbers(thirdNumber.toString()).toLowerCase();
            console.log(hundredsNumbers + ' and ' + numbers);
        }
        else if (thirdNumber === 0) {
            hundredsNumbers = giveHundredsNumbers(firstNumber.toString());
            tenthsNumbers = giveTenthseNumbers(secondNumber.toString()).toLowerCase();
            console.log(hundredsNumbers + ' and ' + tenthsNumbers);
        }
        else if (secondNumber === 1) {
            hundredsNumbers = giveHundredsNumbers(firstNumber.toString());
            numbers = giveTwoDigitsNumbers(thirdNumber.toString()).toLowerCase();
            console.log(hundredsNumbers + ' and ' + numbers);
        }
        else {
            hundredsNumbers = giveHundredsNumbers(firstNumber.toString());
            tenthsNumbers = giveTenthseNumbers(secondNumber.toString()).toLowerCase();
            numbers = giveSingleNumbers(thirdNumber.toString()).toLowerCase();
            console.log(hundredsNumbers + ' and ' + tenthsNumbers + ' ' + numbers);
        }
    }
}


function giveSingleNumbers(number) {
    switch (number) {
        case '0':
            number = 'Zero';
            break;
        case '1':
            number = 'One';
            break;
        case '2':
            number = 'Two';
            break;
        case '3':
            number = 'Three';
            break;
        case '4':
            number = 'Four';
            break;
        case '5':
            number = 'Five';
            break;
        case '6':
            number = 'Six';
            break;
        case '7':
            number = 'Seven';
            break;
        case '8':
            number = 'Eight';
            break;
        case '9':
            number = 'Nine';
            break;
        default:
            break;
    }

    return number;
}

function giveTwoDigitsNumbers(number) {
    switch (number) {
        case '1':
        case '10':
            number = 'Ten';
            break;
        case '1':
        case '11':
            number = 'Eleven';
            break;
        case '2':
        case '12':
            number = 'Twelve';
            break;
        case '3':
        case '13':
            number = 'Òhirteen';
            break;
        case '4':
        case '14':
            number = 'Fourteen';
            break;
        case '5':
        case '15':
            number = 'Fifteen';
            break;
        case '6':
        case '16':
            number = 'Sixteen';
            break;
        case '7':
        case '17':
            number = 'Seventeen';
            break;
        case '8':
        case '18':
            number = 'Eighteen';
            break;
        case '9':
        case '19':
            number = 'Nineteen';
            break;
        default:
            break;
    }

    return number;
}

function giveTenthseNumbers(number) {
    switch (number) {
        case '1':
            number = 'Ten';
            break;
        case '2':
            number = 'Twenty';
            break;
        case '3':
            number = 'Thirty';
            break;
        case '4':
            number = 'Fourty';
            break;
        case '5':
            number = 'Fifty';
            break;
        case '6':
            number = 'Sixty';
            break;
        case '7':
            number = 'Seventy';
            break;
        case '8':
            number = 'Eighty';
            break;
        case '9':
            number = 'Ninety';
            break;
        default:
            break;
    }

    return number;
}

function giveHundredsNumbers(number) {
    switch (number) {
        case '1':
            number = 'One hundred';
            break;
        case '2':
            number = 'Two hundred';
            break;
        case '3':
            number = 'Three hundred';
            break;
        case '4':
            number = 'Four hundred';
            break;
        case '5':
            number = 'Five hundred';
            break;
        case '6':
            number = 'Six hundred';
            break;
        case '7':
            number = 'Seven hundred';
            break;
        case '8':
            number = 'Eight hundred';
            break;
        case '9':
            number = 'Nine hundred';
            break;
        default:
            break;
    }

    return number;
}