// Write a JavaScript function roundNumber(number) that rounds floating-point number
// using Math.round(), Math.floor(). Write a JS program roundingNumbers.js that rounds
// a few sample values. Run the program through Node.js.

function roundNumber(number) {
    var rounded = Math.floor(number);
    var rounded2 = Math.round(number);
    console.log(rounded);
    console.log(rounded2);
}
roundNumber(22.7);
roundNumber(12.3);
roundNumber(58.7);