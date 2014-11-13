// Write a JavaScript function findMaxSequence(arr) that finds the maximal sequence of
// equal elements in an array and returns the result as an array. If there is more than
// one sequence with the same maximal length, print the rightmost one. Write JS program
// sequenceFinder.js that invokes your function with the sample input data below and prints
// the output at the console.

function findMAxSequence(arr) {
    var maxCount = 1;
    var tempCount = 1;
    var tempInd = 0;
    var lastInd = 0;
    var result = [];

    for(var i = 0; i < arr.length - 1; i++) {
        if(arr[i] === arr[i + 1]) {
            tempCount++;
            tempInd = i + 1;
            if(i === arr.length - 2){
                if(tempCount >= maxCount) {
                    maxCount = tempCount;
                    lastInd = tempInd;
                }
            }
        }
        else {
            if(tempCount >= maxCount) {
                maxCount = tempCount;
                lastInd = tempInd;
            }
            tempCount = 1;
        }
    }
    var firstInd = lastInd - maxCount + 1;
    for (var i = firstInd, j = 0; i < firstInd + maxCount; i++, j++) {
        result[j] = arr[i];
    }
    return result;
}
console.log(findMAxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMAxSequence(['happy']));
console.log(findMAxSequence([2, 'qwe', 'qwe', 3, 3, '3']));