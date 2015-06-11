function solve(input) {
    var N = +input[0],
        answer = -2000000,
        sum,
        arr = input.slice(1).map(Number),
        i,
        j;

    for (i = 0; i < N; i += 1) {
        sum = arr[i];
        answer = Math.max(answer, sum);
        for (j = i + 1; j < N; j += 1) {
            sum += arr[j];
            if (answer < sum) {
                answer = sum;
            }
        }
    }
    return answer;
}

var tests = [
    ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'],
    ['6', '1', '3', '-5', '8', '7', '-6'],
    ['9', '-9', '-8', '-8', '-7', '-6', '-5', '-1', '-7', '-6'],
];

tests.forEach(function(test) {
    console.log(solve(test));
});