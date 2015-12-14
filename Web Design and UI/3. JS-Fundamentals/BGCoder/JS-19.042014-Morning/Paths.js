function solve(input) {
    var rowsCols = input[0].split(' '),
        rows = +rowsCols[0],
        cols = +rowsCols[1],
    /*
     * //obj for rows and cols
     * bounds = {
     * rows: +ros=wsCols[0],
     * cols: +rowsCols[1]
     * };
     * */
        direction = {
            u: -1,
            d: +1,
            l: -1,
            r: +1
        },
        dir,
        leftRight,
        upDowan,
        row = 0,
        col = 0,
        sum = 0,
        key,
        visited = {},
        matrix = input.slice(1)
            .map(function (line) {
                return line.split(' ');
            });

    while (1) {

        // check for out of matrix

        //if (!matrix[row] || !matrix[row][col]) {
        //    return 'successed with ' + sum;
        //}

        if (row < 0 || col < 0 ||
            row >= rows || col >= cols) {
            return 'successed with ' + sum;
        }

        // check for visited
        if (matrix[row][col] === 'X') {
            return 'failed at ' + '(' + row + ', ' + col + ')';
        }

        //key = row + ';' + col;
        //
        //if (visited[key]) {
        //    return 'failed at ' + '(' + row + ', ' + col + ')';
        //}
        //
        //visited[key] = true;


        // update sum
        //sum1 = Math.pow(2, row) + col;
        sum += (1 << row) + col;

        //update row and col
        dir = matrix[row][col];

        matrix[row][col] = 'X';

        upDowan = dir[0];
        leftRight = dir[1];

        row += direction[upDowan];
        col += direction[leftRight];
    }
}

// for tests
var tests = [
    [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'

    ],
    [
        '3 5',
        'dr dl dl ur ul',
        'dr dr ul ul ur',
        'dl dr ur dl ur'
    ]
];

tests.forEach(function (test) {
    console.log(solve(test));
})