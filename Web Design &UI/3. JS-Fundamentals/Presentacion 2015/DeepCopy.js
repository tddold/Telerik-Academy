var copy,
    obj = {
    str: 'String',
    num: 5,
    arr:[1, 2, 3],
    obj: {
        name:'Pesho',
        age: 25,
        sex:'male',
    }
};

console.log('This is obj:');
console.log(obj);

copy = deepCopy(null);
console.log('This is deepCopy - null: ' + copy);

copy = deepCopy(obj);
console.log('This is deepCopy - obj: ' + copy);
console.log(copy);

function deepCopy(obj) {
    var prop,
        temp;

    if(obj === null || typeof(obj) !== 'object'){
        return obj;
    }

    temp = obj.constructor(); // changed

    for(prop in obj) {
        if(Object.prototype.hasOwnProperty.call(obj, prop)) {
            temp[prop] = deepCopy(obj[prop]);
        }
    }

    return temp;
}