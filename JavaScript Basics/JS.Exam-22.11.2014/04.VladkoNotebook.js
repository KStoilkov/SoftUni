function notebook (arr) {
    var input = [];
    for (var i = 0 ; i < arr.length;i++) {
        input[i] = arr[i].split('|');
    }
    var result = {};
    for (i = 0; i < input.length; i++) {
        var color = input[i][0];
        if (!result[color]) {
            if (checkForName(color, input) === '' || findAge(color, input) === '') {
                continue;
            }
            else {
                result[color] = {};
            }
        }
        if (!result[color]['age']) {
            result[color]['age'] = findAge(color, input);
        }
        if (!result[color]['name']) {
            result[color]['name'] = checkForName(color, input);
        }
        if (!result[color]['opponents']) {
            result[color]['opponents'] = findOpponents(color, input);
        }
        if (!result[color]['rank']) {
            result[color]['rank'] = findRank(color, input);
        }
    }
    var output = sortObject(result);
    console.log(JSON.stringify(output));

}
function checkForName (color, input){
    for (var i =0; i < input.length; i++) {
        if (input[i][0] === color && input[i][1] === 'name') {
            return input[i][2];
        }
    }
    return '';
}
function findAge (color, input) {
    for(var i = 0; i < input.length; i++) {
        if (color === input[i][0] && input[i][1] === 'age') {
            return input[i][2];
        }
    }
    return '';
}
function findOpponents (color, input) {
    var opponents = [];
    for (var i = 0; i < input.length; i++) {
        if (color === input[i][0]) {
            if (input[i][1] === 'win' || input[i][1] === 'loss') {
                opponents.push(input[i][2]);
            }
        }
    }
    return opponents.sort();
}
function findRank (color, input) {
    var wins = 1;
    var loss = 1;
    for (var i = 0; i < input.length; i++) {
        if (color === input[i][0]) {
            if (input[i][1] === 'win') {
                wins++;
            }
            else if(input[i][1] === 'loss') {
                loss++;
            }
        }
    }
    var rank = parseFloat(wins/loss);
    return rank.toFixed(2);
}
function sortObject(obj) {
    var keys = Object.keys(obj).sort();
    var sorted = {};

    for (var i = 0; i < keys.length; i++) {
        var key = keys[i];
        sorted[key] = obj[key];
    }

    return sorted;
}


notebook(
    [ 'purple|age|99',
        'red|win|hosh',
        'blue|win|pesho',
        'blue|win|mariya',
        'purple|loss|Kiko',
        'purple|loss|Kiko',
        'purple|loss|Kiko',
        'purple|loss|Yana',
        'purple|loss|Yana',
        'purple|loss|Manov',
        'purple|loss|Manov',
        'red|name|gosho',
        'blue|win|Vladko',
        'purple|loss|Yana',
        'purple|name|VladoKaramfilov',
        'blue|age|21',
        'blue|loss|Pesho' ]);
