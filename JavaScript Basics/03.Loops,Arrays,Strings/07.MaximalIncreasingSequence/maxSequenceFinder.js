// Write a JavaScript function findMaxSequence(arr) that finds the maximal increasing
// sequence in an array of numbers and returns the result as an array. If there is no
// increasing sequence the function returns 'no'. Write JS program maxSequenceFinder.js
// that invokes your function with the sample input data below and prints the output
// at the console.


function findMaxSequence(arr) {
    var maxCount = 1;
    var tempCount = 1;
    var lastInd = 0;
    var tempInd = 0;
    var result = [];
    var isFound = false;

    for(var i = 0; i < arr.length - 1; i++) {
        if(arr[i] < arr[i + 1]) {
            tempCount++;
            tempInd = i + 1;
            isFound = true;
            if(i === arr.length - 2){
                if (tempCount > maxCount) {
                    maxCount = tempCount;
                    lastInd = tempInd;
                }
            }
        }
        else {
            if (tempCount > maxCount) {
                maxCount = tempCount;
                lastInd = tempInd;
            }
            tempCount = 1;
        }
    }

    if (!isFound) {
        return 'no';
    }
    else {
        var startIndex = lastInd - maxCount + 1;
        for (var i = startIndex, j = 0; i < startIndex + maxCount; i++, j++) {
            result[j] = arr[i];
        }
        return result;
    }
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));