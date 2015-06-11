function Solve( input ) {

    var rowsColsJumps = parseNumber( input[0] ),
        rows = rowsColsJumps[0],
        cols = rowsColsJumps[1],
        allJumps = rowsColsJumps[2],
        startPos = parseNumber( input[1] ),
        currRow = startPos[0],
        currCol = startPos[1],
        jumps = input.slice( 2 ).map( function ( line ) {
            return parseNumber( line );
        } ),
        field,
        sum = 0,
        totalJums = 0,
        jumpsIndex = 0,
        currJump,
        i,
        j,
        count = 1
        escaped = false;


        field = initField();
        return getAnswer();

    function getAnswer() {
        while ( true ) {
            if ( currRow < 0 || currCol < 0
                || currRow >= rows || currCol >= cols ) {
                escaped = true;
                break;
            }

            if ( field[currRow][currCol] === 'X' ) {
                escaped = false;
                break;
            }

            sum += field[currRow][currCol];
            totalJums += 1;

            field[currRow][currCol] = 'X';

            currRow += (jumps[jumpsIndex])[0];
            currCol += jumps[jumpsIndex][1];

            jumpsIndex += 1;

            if ( jumpsIndex >= jumps.length ) {
                jumpsIndex = 0;
            }
        }

        return escaped
                ? 'escaped ' + sum
                : 'caught ' + totalJums;
    }

    function parseNumber( input ) {
        return input.split( ' ' ).map( Number );
    }

    function initField() {
        field = [];
        for ( i = 0; i < rows; i += 1 ) {
            field[i] = [];

            for ( j = 0; j < cols; j += 1 ) {
                field[i][j] = count;
                count += 1;
            }
        }
        return field;
    }
}


var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
];

console.log( Solve( test ) );