function xRemoval(arr) {
    var input = [];
    for (var i = 0; i < arr.length; i++) {
        input[i] = arr[i].split('');
    }

    var result = input.map(function(arr2) {
        return arr2.slice();
    });

    for (i = 0; i < input.length - 2; i++) {
        for (var j = 0; j < input[i].length - 2; j++) {
            var current = input[i][j].toLowerCase();
            if (input[i + 2][j] !== undefined && input[i][j + 2] !== undefined &&
                input[i + 1][j + 1] !== undefined && input[i + 2][j + 2] !== undefined) {
                if (current === input[i][j + 2].toLowerCase() && current === input[i + 1][j + 1].toLowerCase() &&
                    current  === input[i + 2][j].toLowerCase() && current === input[i + 2][j + 2].toLowerCase()) {
                    result[i][j] = '';
                    result[i][j + 2] = '';
                    result[i + 1][j + 1] = '';
                    result[i + 2][j] = '';
                    result[i + 2][j + 2] = '';
                }
            }
        }
    }

    for (i = 0; i < result.length; i++) {
        var temp = '';
        for (j = 0; j < result[i].length; j++) {
            temp += result[i][j];
        }
        console.log(temp);
    }
}

xRemoval([ 'abnbjs', 'xoBab', 'Abmbh', 'aabab', 'ababvvvv' ]);