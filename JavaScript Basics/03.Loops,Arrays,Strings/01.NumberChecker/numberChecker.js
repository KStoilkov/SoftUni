// Write a JavaScript function printNumbers(number) that accepts as parameter an integer
// number. The function finds all integer numbers from 1 to n that are not divisible by 4
// or by 5. Write a JS program numberChecker.js that invokes your function with the sample
// input data below and prints the output at the console.

function printNumbers(number) {
    var result = [];
    if (number > 0) {
        for (var i = 0; i <= number; i++) {
            if (i % 4 === 0 || i % 5 === 0) {
                continue;
            }
            else {
                result.push(i);
            }
        }
        return result.join(", ");
    }
    else {
        return "no";
    }
}

console.log(printNumbers(20));
console.log(printNumbers(-5));
console.log(printNumbers(13));