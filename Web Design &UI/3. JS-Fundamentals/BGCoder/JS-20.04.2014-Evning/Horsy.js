function solve(input) {
    var rowsCols = input[0].split(' '),
        //rowsCols = input[0].split(' ').map[Number],
        rows = +rowsCols[0],
        cols = +rowsCols[1],
        dir = [
            [-2, 1],
            [-1, 2],
            [1, 2],
            [2, 1],
            [2, -1],
            [1, -2],
            [-1, -2],
            [-2, -1]
        ],
        row = rows - 1,
        col = cols - 1,
        sum = 0,
        count = 0,
        //viseted = [],
        matrix = input.slice(1).map(function (line) {
            return line.split('').map(Number);
        }),
        dirNumber = matrix[row][col];

    while (1) {
        if (!matrix[row] || !matrix[row][col]) {
            return 'Go go Horsy! Collected ' + sum + ' weeds';
        }

        if (matrix[row][col] === 'X') {
            return 'Sadly the horse is doomed in ' + count + ' jumps';
        }

        //if (viseted[row + ' ' + col]) {
        //    return 'Sadly the horse is doomed in ' + count + ' jumps';
        //}

        dirNumber = matrix[row][col];

        sum += getNumber(row, col);
        count += 1;

        matrix[row][col] = 'X';
        // visited = [row + ' ' + col] = true;
        switch (dirNumber) {
            case 1:
                row += dir[0][0];
                col += dir[0][1];
                break;
            case 2:
                row += dir[1][0];
                col += dir[1][1];
                break;
            case 3:
                row += dir[2][0];
                col += dir[2][1];
                break;
            case 4:
                row += dir[3][0];
                col += dir[3][1];
                break;
            case 5:
                row += dir[4][0];
                col += dir[4][1];
                break;
            case 6:
                row += dir[5][0];
                col += dir[5][1];
                break;
            case 7:
                row += dir[6][0];
                col += dir[6][1];
                break;
            case 8:
                row += dir[7][0];
                col += dir[7][1];
                break;
        }

    }

    function getNumber(row, col) {
        return (1 << row) - col;
    }
}


var tests = [
    [
        '3 5',
        '54561',
        '43328',
        '52388'
    ],
    [
        '3 5',
        '54361',
        '43326',
        '52188',
    ],
    [
        '3 170',
        '65256624788315872547146742545371652845427473747267157662731442588248254733848315117257871124376782' +
        '841157534346443612618725181711166757567365663638423518322167414635742267',
        '45455813336725247538881424621676377742372315377756873812547467266271517642434' +
        '424316613753727845166781146278516761172147847651254585283744475617153481423232871713755726637',
        '615547365741122472454528748723146276424624473458283876646855746138315615333883147184633351558' +
        '46275353167535228183566874387343281726347481161154526852575881675721325662347',
    ]
];

tests.forEach(function (test) {
    console.log(solve(test));
});