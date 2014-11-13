// Write a JavaScript function findCardFrequency(str) that that accepts the following parameters:
// string of several cards (face + suit), separated by a space. The function calculates and
// prints at the console the frequency of each card face in format "card_face -> frequency".
// The frequency is calculated by the formula appearances / N and is expressed in percentages
// with exactly 2 digits after the decimal point. The card faces with their frequency
// should be printed in the order of the card face's first appearance in the input.
// The same card can appear multiple times in the input, but its face should be listed
// only once in the output. Write JS program cardFrequencies.js that invokes your function with
// the sample input data below and prints the output at the console.

function findCardFrequency(str) {
    var tempArrOfCards = str.split(/[^0-9A-Z]/);
    var arrOfCards = tempArrOfCards.filter(function(e){return e});
    var faces = {};
    var result = [];

    for (var i = 0; i< arrOfCards.length; i++) {
        var key = arrOfCards[i];
        if(!faces[key]) {
            faces[key] = 0;
        }
        faces[key] += 1;
    }

    for (var i = 0; i < arrOfCards.length; i++) {
        var key = arrOfCards[i];
        if (faces[key]) {
            var frequency = ((faces[key] / arrOfCards.length) * 100).toFixed(2);
            var isFounded = false;
            var output = key + " -> " + frequency + "%";
            for (var j = 0; j < result.length; j++) {
                if (result[j] === output){
                    isFounded = true;
                }
            }
            if (!isFounded) {
                result.push(output);
            }
        }
    }

    return result.join("\n");
}

console.log(findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));
console.log();
console.log(findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠'));
console.log();
console.log(findCardFrequency('10♣ 10♥'));