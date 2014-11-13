// Write a JavaScript function checkBrackets(str) to check if in a given expression
// the brackets are put correctly. Write JS program bracketsChecker.js that invokes
// your function with the sample input data below and prints the output at the console.

function checkBrackets(str){
    var open = 0;
    var close = 0;
    for (var i = 0; i < str.length; i++) {
        if (str.charAt(i) === '(') {
            open++;
        }
        else if (str.charAt(i) === ')'){
            close++;
        }
        if (close > open) {
            return "incorrect"
        }
    }
    if (close === open) {
        return "correct";
    }
    else {
        return "incorrect";
    }
}
console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));