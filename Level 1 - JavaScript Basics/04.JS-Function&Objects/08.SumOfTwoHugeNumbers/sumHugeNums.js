// Write a JavaScript function sumTwoHugeNumbers(value) that accepts as parameter an array
// containing the two numbers. The input numbers are represented as strings. You are not
// allowed to use external libraries. The result should be printed on the console.

function sumTwoHugeNumbers(value) {
    var num1 = value[0].split('');
    var num2 = value[1].split('');

    var bestLength = 0;
    if (num1.length >= num2.length) {
        bestLength = num1.length;
    }
    else {
        bestLength = num2.length;
    }
    num1 = num1.reverse();
    num2 = num2.reverse();
    for (var i = 0; i < bestLength; i++) {
        if (num1[i] === undefined) {
            num1[i] = '0';
        }
        if (num2[i] === undefined) {
            num2[i] = '0';
        }
    }
    num1 = num1.reverse();
    num2 = num2.reverse();

    var sum = [];
    var temp = 0;
    var reminder = 0;
    for (i = num1.length - 1; i >= 0; i--) {
        temp = parseInt(num1[i])+ parseInt(num2[i]) + reminder;
        if (temp > 9) {
            reminder = 1;
            temp = temp % 10;
        }
        else {
            reminder = 0
        }
        sum.push(temp);
    }
    sum = sum.reverse();
    return sum.join('');
}

console.log(sumTwoHugeNumbers(['155', '65']));
console.log(sumTwoHugeNumbers(['123456789', '123456789']));
console.log(sumTwoHugeNumbers(['887987345974539','4582796427862587']));
console.log(sumTwoHugeNumbers(['347135713985789531798031509832579382573195807',
        '817651358763158761358796358971685973163314321']
));