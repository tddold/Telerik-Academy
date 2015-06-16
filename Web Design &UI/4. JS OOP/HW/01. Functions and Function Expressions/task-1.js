/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number
 */

//function UserExceptiom(message) {
//    this.message = message;
//    this.name = 'UserException';
//}

function sum(item) {
    var arr = [],
        sumArr;

    if (Array.isArray(item)) {
        if (!!item.length) {
            arr = item.map(Number);
        } else {
            return null;
        }
    } else if (item === undefined) {
        throw  new Error('Parameter not passed');
    } else {
        if(item.every(function(elem){
                return !isNaN(elem);
            })){
            throw  new Error('Elements not convertible to number');
        }
    }

    sumArr = arr.reduce(function (sum, item) {
        return sum += item;
    }, 0);
    return sumArr;
}

module.exports = sum;