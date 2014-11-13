// Write a JavaScript function reverseString(str) that reverses string and returns it.
// Write JS program stringReverser.js that invokes your function with the sample input
// data below and prints the output at the console.

function reverseString(str) {
    var reversed = [];
    for (var i = 0, j = str.length - 1; i < str.length; i++, j--) {
        reversed[i] = str.charAt(j);
    }
    return reversed.join("");
}

console.log(reverseString('sample'));
console.log(reverseString('softUni'));
console.log(reverseString('java script'));