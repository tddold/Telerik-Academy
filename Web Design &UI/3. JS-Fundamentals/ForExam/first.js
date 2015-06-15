function Solve(input) {
    var i,
        len,
        count = 1,
        parseInput;

    parseInput = input.map(Number);
    len = parseInput.length;

    for (i = 1; i < len; i += 1) {
        if (parseInput[i - 1] >= parseInput[i]) {
            count += 1;
        }
    }

    console.log(input);
    console.log(parseInput);
    console.log(count);




}

var input = ['7', '6', '5', '4', '3', '2'];

Solve(input);


console.log();
console.log(createMatrix(4, 4));


function createMatrix(rows, cols) {
    var row,
        col,
        matrix = [],
        count = 1;

    for (row = 0; row < rows; row += 1) {
        matrix.push([]);

        for (col = 0; col < cols; col += 1) {
            matrix[row][col] = count;
            count += 1;
        }
    }

    return matrix;

}
