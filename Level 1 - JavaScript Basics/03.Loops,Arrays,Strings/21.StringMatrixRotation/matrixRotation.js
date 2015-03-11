function stringMatrixRotator(arr) {
    var rotation = arr[0].split(/[^0-9]/).filter(Boolean);
    rotation = parseInt(rotation[0]);
    while (rotation >= 360) {
        rotation = rotation - 360;
    }
    var words = [];
    for (var i = 1; i < arr.length; i++) {
        words.push(arr[i]);
    }

    if (rotation === 0) {
        console.log(words.join('\n'));
    }
    else {
        rotate(rotation, words);
    }
    function rotate(deg, wordsArr) {
        var bl = 0;

        for (var i = 0; i < wordsArr.length; i++) {
            wordsArr[i] = wordsArr[i].split('');
            var current = wordsArr[i].length;
            if (current > bl) {
                bl = current;
            }
        }

        var res = "";
        if (deg === 90) {
            for (i = 0; i < bl; i++) {
                for (var j = 0; j < wordsArr.length; j++) {
                    if (wordsArr[wordsArr.length - (1 + j)][i] === undefined) {
                        res += " ";
                    }
                    else {
                        res += wordsArr[wordsArr.length - (1 + j)][i];
                    }
                }
                console.log(res);
                res = "";
            }
        }
        else if (deg === 180) {
            for (i = wordsArr.length - 1; i >= 0 ; i--) {
                for (j = bl - 1; j >= 0; j--) {
                    if (wordsArr[i][j] === undefined) {
                        res += " ";
                    }
                    else {
                        res += wordsArr[i][j];
                    }
                }
                console.log(res);
                res = "";
            }
        }
        else if (deg === 270) {
            for (i = bl - 1; i >= 0; i--) {
                for (j = wordsArr.length - 1; j >= 0 ; j--) {
                    if (wordsArr[wordsArr.length - (1 + j)][i] === undefined) {
                        res += " ";
                    }
                    else {
                        res += wordsArr[wordsArr.length - (1 + j)][i];
                    }
                }
                console.log(res);
                res = "";
            }
        }
    }
}


stringMatrixRotator([ 'Rotate(0)', 'hello', 'softuni', 'exam' ]);
stringMatrixRotator([ 'Rotate(90)', 'hello', 'softuni', 'exam' ]);
stringMatrixRotator([ 'Rotate(180)', 'hello', 'softuni', 'exam' ]);
stringMatrixRotator([ 'Rotate(270)', 'hello', 'softuni', 'exam' ]);