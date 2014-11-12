// Write a JavaScript function evenNumber(number) that checks if an integer number
// is even. Write JS program evenChecker.js to check if a few numbers are even.
// The result should be printed on the console (true or false).
// Run the program through Node.js.

function evenNumber(number) {
    if (number % 2 === 0) {
        return true;
    }
    else if (number % 2 != 0 ) {
        return false;
    }
}
console.log(evenNumber(3));
console.log(evenNumber(127));
console.log(evenNumber(588));