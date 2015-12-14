function max(arr){}

console.log(max.length);
console.log(max.name);
console.log(max.caller);
console.log(max.apply());
console.log(function(){}.name);

var arr = [3, 2, 1, 3, 4, 5, 1, 2, 3, 4, 5, 7, 9];
function orderBy(x, y) { return x - y; }
arr.sort(orderBy);
//better to be done using anonymous function
//arr.sort(function(x, y){return x - y;});
console.log(arr);

var numbers = [1,2,3,4,5,6,7,8,9];
var max = Math.max.apply (null, numbers);
function printMsg(msg){
    console.log("Message: " + msg);
}
printMsg.apply(null, ["Important message"]);
//here this is null, since it is not used anywhere in //the function
//more about this in OOP

console.log(max)




