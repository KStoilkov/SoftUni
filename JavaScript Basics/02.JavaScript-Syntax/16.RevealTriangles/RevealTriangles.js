function revealTriangles (arr) {
    var result = [];
    var checker = [];

    for (var i = 0; i < arr.length; i++) {
        result[i] = arr[i].split('');
        checker[i] = arr[i].split('');
    }

    for (i = 0; i < checker.length - 1; i++) {
        for (var j = 0; j <= checker[i].length - 2; j++) {
            if (checker[i][j + 1] === checker[i + 1][j] &&
                checker[i][j + 1] === checker[i + 1][j + 1] &&
                checker[i][j + 1] === checker[i + 1][j + 2]) {

                result[i][j + 1] = '*';
                result[i + 1][j] = '*';
                result[i + 1][j + 1] = '*';
                result[i + 1][j + 2] = '*';
            }
        }
    }

    for (i = 0; i < result.length; i++) {
        console.log(result[i].join(''));
    }
}

revealTriangles(
    ["abcdexgh",
    "bbbdxxxh",
    "abcxxxxx"]
);
revealTriangles(
    ["aa",
    "aaa",
    "aaaa",
    "aaaaa"]
);