//Write a JavaScript function convertKWtoHP(number) that accepts number variable to
// convert car’s kW into hp (horse power). Write a JS program powerfulCars.js that
// converts a few sample values to hp (see the examples below). The result should be
// printed on the console, rounded up to the second sign after the decimal point.
// Run the program through Node.js.

function convertKWtoHP(number){
    var hp = (number * 1.34102209).toFixed(2);
    console.log(hp);
}
convertKWtoHP(75);
convertKWtoHP(150);
convertKWtoHP(1000);