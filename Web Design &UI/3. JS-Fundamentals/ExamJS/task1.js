function solve(input) {
    var nk = input[0].split(' ').map(Number),
        s = input[1].split(' ').map(Number),
        k = nk[1],
        result = 0,
        i,
        j,
        len,
        a,
        b,
        arrTrans = [];

    if (k === 0) {
        result = s.reduce(function (sum, item) {
            return sum + item;
        }, result);
    } else {

        for (j = 0; j < k; j += 1) {
            for (i = 0, len = s.length; i < len; i += 1) {
                if (i === 0) {
                    a = s[len - 1];
                    b = s [i + 1];
                } else if (i === len - 1) {
                    a = s[i - 1];
                    b = s[0];
                } else {
                    a = s[i - 1];
                    b = s[i + 1];
                }

                if (s[i] === 0) {
                    arrTrans.push(getMax(a, b) - getMin(a, b));
                } else if (s[i] === 1) {
                    arrTrans.push(a + b);
                } else if (!(s[i] % 2)) {
                    arrTrans.push(getMax(a, b));
                } else if (!!(s[i] % 2)) {
                    arrTrans.push(getMin(a, b));
                }
            }

            s = arrTrans;
            if (j < k - 1) {
                arrTrans = [];
            } else {
                result = arrTrans.reduce(function (sum, item) {
                    return sum + item;
                }, result);
            }
        }
    }


    function getMin(a, b) {
        if (a >= b) {
            return b;
        } else {
            return a;
        }
    }

    function getMax(a, b) {
        if (a >= b) {
            return a;
        } else {
            return b;
        }
    }

    console.log(result);
}

var tests = [
    ['5 3', '1 1 1 1 1'],
    ['5 0', '9 0 2 4 1'],
    ['10 3', '1 9 1 9 1 9 1 9 1 9'],
    ['10 10', '0 1 2 3 4 5 6 7 8 9',]
];

tests.forEach(function (test) {
    console.log(solve(test));
});