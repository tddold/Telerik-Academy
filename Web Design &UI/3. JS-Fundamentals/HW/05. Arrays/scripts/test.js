/**
 * Created by Tdd on 25.5.2015 ã..
 */
Array.prototype.compareLexicographically = function (arr){
    for(var ind = 0; ind < Math.min(this.length, arr.length); ind++){
        if(arr[ind] !== this[ind]){
            return this[ind] < arr[ind] ? -1 : 1;
        }
    }

    if(this.length != arr.length){
        this.length < arr.length ? -1 : 1;
    }

    return 0;
}

var a = 'abc'.split(''), b = 'abcd'.split('');

console.log(a.compareLexicographically(b));





function addArrayA() {

    var input = document.createElement("INPUT");
    input.type = 'text';
    input.value = 'stop';
    document.getElementById("myList").appendChild(input);
}


function removeInput() {
    var input = document.getElementById('myList'),
        lastChild = input.lastChild;
    if (lastChild) {
        input.removeChild(lastChild);
        /* fields -= 1;*/
    }
}
