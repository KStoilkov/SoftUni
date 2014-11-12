// Write a JavaScript function bitChecker(number) that finds if the bit 3 an integer number
// (counting from 0) is 1. Write JS program checkingBits.js to check a few numbers.
// The result (true or false) should be printed on the console.
// Run the program through Node.js.

function bitChecker(number) {
    var mask = 1 << 3;
    var nAndM = number & mask;
    var bit = nAndM >> 3;
    if (bit === 1) {
        return true;
    }
    else {
        return false;
    }
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));