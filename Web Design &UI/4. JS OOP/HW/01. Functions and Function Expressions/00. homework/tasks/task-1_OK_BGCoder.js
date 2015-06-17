/*function solve(numbers) {
    return function(numbers) {

        if(numbers.length === 0){
            return null;
        }

        return numbers.reduce(function(s,n){
            n = +n;

            if(isNaN(n)){
                throw new Error();
            }
            return s + n;
        }, 0);
    }
}

module.exports = solve;*/


     function sum(numbers) {

        if(numbers.length === 0){
            return null;
        }

        return numbers.reduce(function(s,n){
            n = +n;

            if(isNaN(n)){
                throw new Error();
            }
            return s + n;
        }, 0);
    }

module.exports = sum;