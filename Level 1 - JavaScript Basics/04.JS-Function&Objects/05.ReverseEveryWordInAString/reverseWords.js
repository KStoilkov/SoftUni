// Write a JavaScript function reverseWordsInString(str) that accepts as a parameter a string
// and reverses the characters of every word in the string but leaves the words in the same
// order. Words are considered to be sequences of characters separated by spaces.

function reverseWordsInString(str) {
    var result = "";
    var strArray = str.split(" ");
    for (var i = 0; i < strArray.length; i++) {
        result += reverseString(strArray[i]) + " ";
    }
    return result;
}
function reverseString(str) {
    var reversed = "";
    for (var i = 0, j = str.length - 1; i < str.length; i++, j--) {
        reversed += str.charAt(j);
    }
    return reversed;
}

console.log(reverseWordsInString(
    'Hello, how are you.'
));
console.log(reverseWordsInString(
    'Life is pretty good, isn’t it?'
));