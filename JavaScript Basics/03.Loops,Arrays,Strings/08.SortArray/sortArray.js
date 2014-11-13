// Sorting an array means to arrange its elements in increasing order. Write a JavaScript
// function sortArray(arr) to sort an array. Use the "selection sort" algorithm: find the
// smallest element, move it at the first position, find the smallest from the rest,
// move it at the second position, etc. Write JS program arraySorter.js that invokes your
// function with the sample input data below and prints the output at the console.

function sortArray(arr) {
    return arr.sort(
        function(a, b) {
            return a - b;
        }
    );
}

console.log(sortArray([5, 4, 3, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));