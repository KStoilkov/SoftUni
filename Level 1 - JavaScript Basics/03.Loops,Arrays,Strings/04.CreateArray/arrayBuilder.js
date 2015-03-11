// Write a JavaScript function createArray() that allocates array of 20 integers and initializes
// each element by its index multiplied by 5. Write JS program arrayBuilder.js
// that invokes your and prints the output at the console.

function createArray() {
    var arr = [];
    for (var i = 0; i <= 20; i++) {
        arr.push(i * 5);
    }
    return arr.join(" ");
}
console.log(createArray());