// Write a JavaScript function findLargestBySumOfDigits(arr) that accepts as a parameter an
// array of numbers or/and strings and returns the element with the largest sum of its digits.
// The function should take a variable number of arguments. It should return undefined when 0 arguments
// are passed or when some of the arguments is not an integer number. Write a JS program
// largestSumOfDigits.js that invokes your function with the sample input data below and prints
// its output at the console.

function findLargestBySumOfDigits(arr) {
    var bestDigitsSum = 0;
    var pos = 0;

    for (var i = 0; i < arr.length; i++) {
        var currentNum = arr[i];
        if (typeof(currentNum) !== "number") {
            return undefined;
        }
        else if (currentNum % 1 !== 0) {
            return undefined;
        }
    }

    for (i = 0; i < arr.length; i++) {
        var currentDigitsSum = findDigitsSum(arr[i]);
        if (currentDigitsSum > bestDigitsSum) {
            bestDigitsSum = currentDigitsSum;
            pos = i;
        }
    }
    return arr[pos];
}

function findDigitsSum(number) {
    if (number < 0) {
        number = number * -1;
    }
    var numAsString = number + '';
    var sum = 0;
    for (var i = 0; i < numAsString.length; i++) {
        sum += parseInt(numAsString.charAt(i));
    }
    return sum;
}

console.log(findLargestBySumOfDigits([5, 10, 15, 111]));
console.log(findLargestBySumOfDigits([33, 44, -99, 0, 20]));
console.log(findLargestBySumOfDigits(['hello']));
console.log(findLargestBySumOfDigits([5, 3.3]));