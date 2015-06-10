function solve(input) {
    var s = +input[0],
        c1 = +input[1],
        c2 = +input[2],
        c3 = +input[3],
        answer = 0,
        price,
        i,
        j,
        k;

    for (i = 0; i < (s / c1) +1; i += 1) {
        for (j = 0; j < (s / c2)+1; j += 1) {
            for (k = 0; k < (s / c3)+1; k += 1) {
                price = c1 * i + c2 * j + c3 * k;
                if (price <= s) {
                    answer = Math.max(answer, price);
                }
            }
        }
    }

    console.log( answer);

}

var tests = [
    ['110', ' 13', '15', '17'],
    ['20', ' 11', '200', '300'],
    ['110', ' 19', '29', '39'],
    ['11']
];

tests.forEach(function (test) {
    console.log(solve(test));
})
