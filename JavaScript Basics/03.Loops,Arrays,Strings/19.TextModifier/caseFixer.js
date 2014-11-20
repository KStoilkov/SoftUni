function fixCasing(str) {
    var result = "";

    var splitted = str.split(' ');
    console.log(splitted);
    for (var i = 0; i < splitted.length; i++) {
        var word = splitted[i];
        if (splitted[i].substring(0, 9) === "<mixcase>") {
            if (word.substring(word.length - 10, word.length) !== "</mixcase>") {
                word += ' ' + splitted[i + 1];
                i++;
            }
            word = word.substring(9, word.length - 10);
            word = randomCasing(word);
        }
        else if (word.substring(0, 9) === "<lowcase>") {
            if (word.substring(word.length - 10, word.length) !== "</lowcase>") {
                word += ' ' + splitted[i + 1];
                i++;
            }
            word = word.substring(9, splitted[i].length - 10);
            word = word.toLowerCase();
        }
        else if(word.substring(0, 8) === "<upcase>") {
            if (word.substring(word.length - 9, word.length) !== "</upcase>") {
                word += ' ' + splitted[i + 1];
                i++;
            }
            word = word.substring(8, word.length - 10);
            word = word.toUpperCase();
        }
        result += word + ' ';
    }

    return result;
}

function randomCasing(word) {
    var modWord = "";
    var chars = word.split('');
    for (var i = 0; i < chars.length; i++) {
        var rand = Math.floor(Math.random() * 2);
        if (rand === 0) {
            chars[i] = chars[i].toUpperCase();
        }
        else {
            chars[i] = chars[i].toLowerCase();
        }
        modWord += chars[i];
    }
    return modWord;
}
console.log(fixCasing(
    "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else."
    )
);