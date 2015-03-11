function tableRow(arr) {
    var input = [];
    var splitted = [];
    for (var i = 2 ; i < arr.length - 1; i++) {
        input[i] = arr[i].split(/[^.0-9 -]/);
        splitted.push(input[i].filter(Boolean));
    }

    var bestSumIndex = 0;
    var currentSum = 0;
    var bestSum = 0;
    var numFounded = false;
    for (i = 0; i < splitted.length; i++) {
        for (var j = 0; j < splitted[i].length; j++) {
            if (splitted[i][j] !== '-') {
                numFounded = true;
                currentSum += parseFloat(splitted[i][j]);
            }
        }
        if (currentSum > bestSum) {
            bestSum = currentSum;
            bestSumIndex = i;
        }
        currentSum = 0;
    }
    if (numFounded) {
        var result = [];
        for (i = 0; i < splitted[bestSumIndex].length; i++) {
            if (splitted[bestSumIndex][i] !== '-') {
                result.push(splitted[bestSumIndex][i]);
            }
        }
        console.log(bestSum + " = " + result.join(' + '));

    } else {
        console.log('no data');
    }
}


tableRow([ '<table>',
    '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
    '<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
    '<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
    '<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>',
    '<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
    '</table>' ]);

