function tetriminos(arr) {
    var input = [];
    var result = {'I': 0, 'L': 0, 'J': 0, 'O': 0, 'Z': 0, 'S': 0, 'T': 0};
    for (var i = 0; i < arr.length; i++) {
        input[i] = arr[i].split('');
    }
    var len = input[0].length;

    // Looking for 'I'
    for (i = 0; i < len; i++) {
        for (var j = 0; j < input.length - 3; j++) {
            if (input[j][i] === 'o' && input[j + 1][i] === 'o' &&
                input[j + 2][i] === 'o' && input[j + 3][i] === 'o') {

                if (!result['I']) {
                    result['I'] = 0;
                }
                result['I'] += 1;
            }

        }
    }

    // Looking for 'L'
    for (i = 0 ; i < len - 1; i++) {
        for (j = 0; j < input.length - 2; j++) {
            if (input[j][i] === 'o' && input[j + 1][i] === 'o' &&
                input[j + 2][i] === 'o' && input[j + 2][i + 1] === 'o') {

                if (!result['L']) {
                    result['L'] = 0;
                }
                result['L'] += 1;
            }
        }
    }

    // Looking for 'J'
    for (i = 1; i < len; i++) {
        for (j = 0; j < input.length - 2; j++) {
            if (input[j][i] === 'o' && input[j + 1][i] === 'o' &&
                input[j + 2][i] === 'o' && input[j + 2][i - 1] === 'o') {
                result['J'] += 1;
            }
        }
    }

    // Looking for 'O'
    for (i = 0; i < len - 1; i++) {
        for (j = 0; j < input.length - 1; j++) {
            if (input[j][i] === 'o' && input[j + 1][i] === 'o' &&
            input[j][i + 1] === 'o' && input[j + 1][i + 1] === 'o') {
                result['O'] += 1;
            }
        }
    }

    //Looking for 'Z', 'S' & 'T'
    for (i = 0; i < len - 2; i++) {
        for (j = 0; j < input.length - 1; j++) {
            if (input[j][i] === 'o' && input[j][i + 1] === 'o' &&
                input[j + 1][i + 1] === 'o' && input [j + 1][i + 2] === 'o') {
                result['Z'] += 1;
            }
            if (input[j + 1][i] === 'o' && input[j + 1][i + 1] === 'o' &&
                input[j][i + 1] === 'o' && input[j][i + 2] === 'o') {
                result['S'] += 1;
            }
            if (input[j][i] === 'o' && input[j][i + 1] === 'o' &&
                input[j + 1][i + 1] === 'o' && input[j][i + 2] === 'o') {
                result['T'] += 1;
            }
        }
    }
    var results = JSON.stringify(result);
    console.log(results);
}
console.log(
    tetriminos([ '--o--o-',
                 '--oo-oo',
                 'ooo-oo-',
                 '-ooooo-',
                 '---oo--'
    ])
);
console.log (
    tetriminos(
        [
            '-oo',
            'ooo',
            'ooo'
        ]
    )
);
