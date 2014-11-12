// Write a JavaScript function calcSupply(age, maxAge, food, foodPerDay) that accepts the following
// parameters: your age (years), your maximum age (years), your favorite food name (e.g. "chocolate"),
// estimate amount of your favorite food per day (a number). The function calculates
// how many of the food you will eat for the rest of your life.
// Write JS program lifetimeSupplyCalc.js that calculates the amount of a few foods that
// you will eat. The result should be printed on the console.
// Run the program through Node.js.

function calcSupply(age, maxAge, food, foodPerDay) {
    var days = (maxAge - age) * 365;
    var result = days * foodPerDay;
    console.log(result + "kg of " + food + " would be enough until I am " + maxAge + " years old.");
}
calcSupply(38, 118, "chocolate", 0.5);
calcSupply(20, 87, "fruits", 2);
calcSupply(16, 102, "nuts", 1.1);