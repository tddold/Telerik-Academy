function Solve( input ) {
    var i,
        len,
        answer = 1,
        N = parseInt( input[0] );
    //console.log( input );
    input = input.map( Number );
    //console.log( input );

    for ( i = 2, len = input.length; i < len; i += 1 ) {
        if ( input[i - 1] > input[i] ) {
            answer += 1;
        }
    }
    //console.log( answer );
    return answer
}

var test1 = ['7 ', '1 ', '2 ', '-3', '4 ', '4 ', '0 ', '1 '];
var test2 = ['6', '1 ', '3 ', '-5', '8 ', '7 ', '-6'];
var test3 = ['9', '1', '8', '8', '7', '6', '5', '7', '7', '6'];

console.log( Solve( test1 ) );
console.log( Solve( test2 ) );
console.log( Solve( test3 ) );
