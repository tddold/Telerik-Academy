function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        i,
        move,
        row,
        col,
        R,
        B,
        Q,
        dirs = {
            l: {row: 0, col: -1},
            r: {row: 0, col: +1},
            u: {row: -1, col: 0},
            d: {row: +1, col: 0},
            ul: {row: -1, col: -1},
            ur: {row: -1, col: +1},
            dl: {row: +1, col: -1},
            dr: {row: +1, col: +1},
            cl: {row: 0, col: 0}
        },
        matrix = [],
        result = '',
        endRow,
        endCol = '',
        dir;

    matrix = getEmptiCellOnBoard(params, rows);
    //console.log(matrix); // TO DO

    for (i = 0; i < tests; i += 1) {
        move = params[rows + 3 + i];
        row = +move[1] - 1;
        col = move[0].charCodeAt(0) - 97;
        endRow = +move[4] - 1;
        endCol = move[3].charCodeAt(0) - 97;

        switch (matrix[row][col]) {
            case '-':
                result = 'no';
                break;
            case 'R':
                dir = getDir(row, col, endRow, endCol);

                if (dir !== 'cl' &&
                    (dir === 'l' ||
                    dir === 'r' ||
                    dir === 'u' ||
                    dir === 'd')) {
                    result = getResult(row, col, endRow, endCol, dir, matrix);

                } else {
                    result = 'no';
                }
                break;
            case 'B':
                dir = getDir(row, col, endRow, endCol);

                if (dir === 'cl' ||
                    dir === 'l' ||
                    dir === 'r' ||
                    dir === 'u' ||
                    dir === 'd') {
                    result = 'no';
                } else {
                    result = getResult(row, col, endRow, endCol, dir, matrix);
                }
                break;
            case'Q':
                dir = getDir(row, col, endRow, endCol);
                if (dir === 'cl') {
                    result = 'no';
                } else {
                    result = getResult(row, col, endRow, endCol, dir, matrix);
                }
                break;
        }

        // Your solution here
        console.log( result); // or console.log('no');
    }

    function getResult(row, col, endRow, endCol, dir, matrix) {
        while (1) {
            row += dirs[dir].row;
            col += dirs[dir].col;

            if (matrix[row][col] !== '-') {
                return 'no';
            }

            if (row === endRow && col === endCol) {
                return 'yes';
            }


        }
    }

    function getEmptiCellOnBoard(params, rows) {
        for (var i = 0; i < rows; i += 1) {
            matrix[rows - i - 1] = params[i + 2].split('');
        }
        return matrix;
    }

    function getDir(row, col, endRow, endCol) {

        if (row === endRow && col === endCol) {
            return 'cl';
        } else if (row === endRow && col < endCol) {
            return 'r';
        } else if (row === endRow && col > endCol) {
            return 'l';
        } else if (row < endRow && col === endCol) {
            return 'd';
        } else if (row > endRow && col === endCol) {
            return 'u';
        } else if (row < endRow && col > endCol) {
            return 'dl';
        } else if (row < endRow && col < endCol) {
            return 'dr';
        } else if (row > endRow && col > endCol) {
            return 'ul';
        } else if (row > endRow && col < endCol) {
            return 'ur';
        }
    }
}


var tests = [
    [
        '3',
        '4',
        '--R-',
        'B--B',
        'Q--Q',
        '12',
        'd1 b3',
        'a1 a3',
        'c3 b2',
        'a1 c1',
        'a1 b2',
        'a1 c3',
        'a2 b3',
        'd2 c1',
        'b1 b2',
        'c3 b1',
        'a2 a3',
        'd1 d3',
    ],
    [
        '5',
        '5',
        'Q---Q',
        '-----',
        '-B---',
        '--R--',
        'Q---Q',
        '10',
        'a1 a1',
        'a1 d4',
        'e1 b4',
        'a5 d2',
        'e5 b2',
        'b3 d5',
        'b3 a2',
        'b3 d1',
        'b3 a4',
        'c2 c5',
    ]
];

//solve(tests);

 tests.forEach(function (test) {
 //console.log(solve(test));
 solve(test);

 });
