// Write a JavaScript function soothsayer(numsArr, langsArr, citiesArr, carsArr)
// that accepts the following parameters (source arrays): array of numbers,
// array of programming languages, array of cities, array of cars.
// Each array must consist of five elements. The function must return an array result[]
// that consists of one random item from each source array. Write a JS program that
// prints on the console the following output: “You will work result[0] years on
// result[1]. You will live in result[2] and drive result[3].”.
// Run the program through Node.js.

function soothsayer(numsArr, langsArr, citiesArr, carsArr) {
    var result = [
        numsArr[getRandom()],
        langsArr[getRandom()],
        citiesArr[getRandom()],
        carsArr[getRandom()]
    ];

    return "You will work " + result[0] + " years on "
        + result[1] + ". You will live in " + result[2] +
        " and drive " + result[3] + ".";
}
function getRandom() {
    return Math.floor(Math.random() * 5);
}

console.log(soothsayer(
    [3, 5, 2, 7, 9],
    ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'],
    ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'],
    ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']
));