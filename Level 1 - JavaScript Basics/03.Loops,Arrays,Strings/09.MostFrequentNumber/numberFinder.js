// Write a JavaScript function findMostFreqNum(arr) that finds the most frequent number
// in an array. If multiple numbers appear the same maximal number of times, print the
// leftmost of them. Write JS program numberFinder.js that invokes your function with
// the sample input data below and prints the output at the console.

function findMostFreqNum(arr){
    var bestLenght = 1;
    var bestNum;
    for (var i = 0; i < arr.length; i++) {
        var currentLength = 1;
        var currentNum = arr[i];
        for (var j = i + 1; j < arr.length; j++) {
            if (currentNum === arr[j]) {
                currentLength++;
            }
        }
        if (currentLength > bestLenght) {
            bestLenght = currentLength;
            currentLength = 1;
            bestNum = currentNum;
        }
    }
    if (bestNum == undefined) {
        bestNum = arr[0];
    }
    return bestNum + " ( " + bestLenght + " times )";
}
console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));