// Write a JavaScript function checkDigit(number) that finds if the third digit (right-to-left)
// of an integer number n (n>1000) is 3. Write JS program digitChecker.js that checks a few numbers.
// The result (true or false) should be printed on the console.
// Run the program through Node.js.

function checkDigit(number) {
    var toStr = number + "";
    var n = toStr.split("");
    var rev = n.reverse();
    if (rev[2] === '3') {
        return true;
    }
    else {
        return false;
    }
}
console.log(checkDigit(1245));
console.log(checkDigit(25368));
console.log(checkDigit(123456));