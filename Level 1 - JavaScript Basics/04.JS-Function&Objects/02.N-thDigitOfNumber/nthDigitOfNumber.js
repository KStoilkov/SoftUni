// Write a JavaScript function findNthDigit(arr) that accepts as a parameter an array of two
// numbers num and n and returns the n-th digit of given decimal number num counted from right
// to left. Return undefined when the number does not have n-th digit. Write a JS program
// nthDigitOfNumber.js that invokes your function with the sample input data below and prints
// the output at the console.

function findNthDigit(arr) {
    var num = arr[0];
    var n = removeFloatingPoint(arr[1]); // returns array
    if (num <= n.length) {
        return n[n.length - num];
    }
    else {
        return "The number doesn't have " + num + " digits";
    }
}
function removeFloatingPoint(number) {
    var numToStr = number + '';
    var n = numToStr.split('.');
    var result = [];
    var temp = "";
    for (var i = 0; i < n.length; i++ ) {
        temp += n[i];
    }
    for (i = 0; i < temp.length; i++) {
        result[i] = temp.charAt(i);
    }
    return result;
}

console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));