// Write a JavaScript function variablesTypes(arr) that accepts the following parameters:
// name, age, isMale (true or false), array of your favorite foods.
// The function must return the values of the variables and their types.

function variablesTypes(arr) {
    return "My name: " + arr[0] + " //type is " + typeof(arr[0]) + "\n" +
    "My age: " + arr[1] + " //type is " + typeof(arr[1]) + "\n" +
    "I am male:" + arr[2] + " //type is " + typeof(arr[2]) + "\n" +
    "My favorite food are: " + arr[3] + " //type is " + typeof(arr[3]) + "\n";

}

console.log(variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]));
console.log(variablesTypes(['Penka', 32, false, ['eggs', 'watermelon', 'donuts']]));
console.log(variablesTypes(['Toshko', 12, true, ['candies', 'ice cream', 'chips']]));