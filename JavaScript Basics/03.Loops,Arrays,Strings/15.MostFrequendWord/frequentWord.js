// Write a JavaScript function findMostFreqWord(str) that finds the most frequent word
// in a text and prints it, as well as how many times it appears in format "word -> count".
// Consider any non-letter character as a word separator. Ignore the character casing.
// If several words have the same maximal frequency, print all of them in alphabetical
// order. Write JS program frequentWord.js that invokes your function with the sample
// input data below and prints the output at the console.

function findMostFreqWord(str) {
    var splitted = str.toLowerCase().split(/[^a-z]+/);
    var allWords = [];
    allWords.push(splitted[0]);
    var results = [];

    for (var i = 0; i < splitted.length; i++) {
        var currentWord = splitted[i];
        var isNotFounded = true;
        for (var j = 0; j < allWords.length; j++) {
            if (allWords[j] === currentWord) {
                isNotFounded = false;
            }
        }
        if (isNotFounded) {
            allWords.push(currentWord);
        }
    }

    var wordsFreqByIndex = [allWords.length];
    var counter = 0;
    for (var i = 0; i < allWords.length; i++) {
        for (var j = 0; j < splitted.length; j++) {
            if (allWords[i] === splitted[j]) {
                counter++;
            }
        }
        wordsFreqByIndex[i] = counter;
        counter = 0;
    }

    var bestFreq = findBestFreq(wordsFreqByIndex);
    for (var i = 0; i < allWords.length; i++) {
        if (wordsFreqByIndex[i] == bestFreq) {
            results.push(allWords[i] + " -> " + bestFreq + " times");
        }
    }

    return results.join("\n");
}

function findBestFreq(arr) {
    var best = 0;
    var current = 0;
    for (var i = 0; i < arr.length; i++) {
        current = arr[i];
        if (current > best) {
            best = current;
        }
    }
    return best;
}

console.log(
    findMostFreqWord(
        'in the middle of the night'
    )
);
console.log();
console.log(
    findMostFreqWord(
        'Welcome to SoftUni. Welcome to Java. Welcome everyone.'
    )
);
console.log();
console.log(
    findMostFreqWord(
        'Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'
    )
);
