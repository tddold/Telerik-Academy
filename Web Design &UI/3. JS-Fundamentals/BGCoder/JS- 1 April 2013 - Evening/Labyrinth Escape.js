function solve(input) {
    var rowsCols = input[0].split(' ').map(Number),
        rows = rowsCols[0],
        cols = rowsCols[1],
        startPos = input[1].split(' ').map(Number),
        row = startPos[0],
        col = startPos[1],
        matrix = input.slice(2).map(function (line) {
            return line.split('');
        }),
        sum = 0,
        count = 0,
        dir,
        /*dirs = {
            l: {
                row: 0,
                column: -1
            },
            r: {
                row: 0,
                column: 1
            },
            u: {
                row: -1,
                column: 0
            },
            d: {
                row: 1,
                column: 0
            },
        },*/
        visited = [];

    // create matrix
    /* var count =1,
     testMatrix = [];
     for(var i = 0; i< 3; i+=1){
     testMatrix[i]= [];
     for(var j= 0; j< 4; j+=1){
     testMatrix[i][j] = count++;
     }
     }*/

    while (1) {
        if (row < 0 || row >= rows ||
            col < 0 || col >= cols) {
            return 'out ' + sum;
        }

        if (visited[row + ' ' + col]) {
            return 'lost ' + count;
        }

        dir = matrix[row][col];
        sum += getValue(row, col);
        count += 1;

        visited[row + ' ' + col] = true;

        switch (dir) {
         case 'l':
         col += -1;
         break;
         case 'r':
         col += 1;
         break;
         case 'u':
         row += -1;
         break;
         case 'd':
         row += 1;
         break;
         }
       /* row += dirs[dir].row;
        col += dirs[dir].column;*/
    }

    function getValue(row, col) {
        return row * cols + col + 1;
    }
}

var tests = [
    [
        "3 4",
        "1 3",
        "lrrd",
        "dlll",
        "rddd"
    ],
    [
        "5 8",
        "0 0",
        "rrrrrrrd",
        "rludulrd",
        "durlddud",
        "urrrldud",
        "ulllllll"
    ],
    [
        "5 8",
        "0 0",
        "rrrrrrrd",
        "rludulrd",
        "lurlddud",
        "urrrldud",
        "ulllllll"
    ],
    [
        '48 12',
        '30 11',
        'ulrddulrlllr',
        'rlrurldrduru',
        'dlluulruludr',
        'ruulddllrrrr',
        'uuuururdudru',
        'ludruuldldrl',
        'uurdlurllldd',
        'udrrrrlurrdl',
        'rlrllullrldd',
        'urrdlldruddl',
        'ulllrduulldr',
        'uudrdudldudd',
        'ddlludurdlur',
        'drurrlulrrlr',
        'llrrdrdrlllu',
        'uddlrdudrdud',
        'dlurrrldrudl',
        'drrlluururdu',
        'dlluddrdrruu',
        'dlrldlrddrdr',
        'llrluruldruu',
        'lururruldddr',
        'uduldduldudr',
        'luurllululdl',
        'ldlddruldruu',
        'dlddldlrudll',
        'luduurllddrd',
        'rldlrrulrrud',
        'lldurdrdurru',
        'rdrluludlrlr',
        'rdduudllrdld',
        'rrurdruruuur',
        'ddruluuldduu',
        'dlllulrruuur',
        'urrllulludll',
        'ludllddudrur',
        'ldddrrduurru',
        'udrluldrrddr',
        'llluururdddl',
        'lllrdrrlrlud',
        'dudruudlrlul',
        'lurudrlududd',
        'rlrrduddrlud',
        'rrdldrldrdul',
        'dldrrddllrrl',
        'rdldduurdrrl',
        'udlldrlrulru',
        'udduldurdrur',
    ]
];

tests.forEach(function (test) {
    console.log(solve(test));
});