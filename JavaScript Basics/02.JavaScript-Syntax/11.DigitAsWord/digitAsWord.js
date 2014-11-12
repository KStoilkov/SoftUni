// Write a JavaScript function convertDigitToWord(value) that prints the name of an
// integer number n (0<n<10) in English using switch statement.
// Write JS program digitAsWord.js that prints a few digits on the console.
// Run the program through Node.js.

function convertDigitToWord(value) {
    switch(value) {
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "The numbers must be bigger than 0 and less than 10";
    }
}

console.log(convertDigitToWord(8));
console.log(convertDigitToWord(3));
console.log(convertDigitToWord(5));