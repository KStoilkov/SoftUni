// Write a JavaScript function divisionBy3(number) that finds the sum of digits of integer
// number n (n > 9) and checks if the sum is divided by 3 without remainder.
// Write JS program divisionChecker.js to check a few numbers. The result should be
// printed on the console (“the number is divided by 3 without remainder” or
// “the number is not divided by 3 without remainder”).
// Run the program through Node.js.

function divisionBy3(number) {
    if (number % 3 === 0) {
        console.log("the number is divided by 3 without remainder");
    }
    else {
        console.log("the number is not divided by 3 with without remainder");
    }
}

divisionBy3(12);
divisionBy3(188);
divisionBy3(591);