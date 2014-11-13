// Write a JavaScript function findMinAndMax(arr) that accepts as parameter an array of numbers.
// The function finds the minimum and the maximum number. Write a JS program
// minMaxNumbers.js that invokes your function with the sample input data below and prints
// the output at the console.

function findMinAndMax(arr) {
    var sorted = arr.sort(
        function(a, b) {
            return a > b;
        }
    );
    return "Min -> " + sorted[0] + "\n" + "Max -> " + sorted[sorted.length - 1] + "\n";
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));