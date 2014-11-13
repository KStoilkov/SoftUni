// Write a JavaScript function findPalindromes(str) that extracts from a given text all palindromes,
// e.g. "ABBA", "lamal", "exe". Write JS program palindromesExtract.js that invokes your function
// with the sample input data below and prints the output at the console.

function findPalindromes(str){
    var splitted = str.toLowerCase().split(/[^a-z]+/);
    var results = [];
    for (var i = 0; i < splitted.length; i++) {
        var currentWord = splitted[i];
        if (isPalindrome(currentWord) && currentWord.length > 0) {
            results.push(currentWord);
        }
    }
    return results.join(", ");
}
function isPalindrome(word) {
    var reversed = word.split('').reverse().join('');
    if (reversed === word) {
        return true;
    }
    else {
        return false;
    }
}
console.log(findPalindromes('There is a man, his name was Bob.'));