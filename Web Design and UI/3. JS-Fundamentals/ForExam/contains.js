function contains(arr, value, start, end){
    var i,
        start = start || 0,
        end = end || arr.length;

    for ( i = start; i < end; i+=1) {
        if (arr[i] === value){
            return true;
        }
    }
    return false;
}

console.log(contains([1,2,3,4,5], 4, 1));