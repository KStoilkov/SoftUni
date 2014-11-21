function autoComplete(args) {
    var words = args[0].split(' ');
    var tempKeywords = [];
    for (var i = 1; i< args.length; i++ ) {
        tempKeywords[i] = args[i].toLowerCase();
    }



    var keywords = tempKeywords.filter(function(e) {return e});
    for (i = 0; i < keywords.length; i++) {
       console.log(findBestMatch(keywords[i], words));
    }
}

function findBestMatch(keyword, arrOfWords) {
    var allMatches = [];
    var matchFound = false;

    //checking for matches
    for (var i = 0; i < arrOfWords.length; i++) {
        if (keyword.toLowerCase() === arrOfWords[i].substring(0, keyword.length).toLowerCase()) {
            var currentMatch = arrOfWords[i];
            matchFound = true;
            allMatches.push(currentMatch);
        }
    }
    if (!matchFound) {
        return "-";
    }
    else if (allMatches.length === 1) {
        return allMatches[0];
    }
    else  {


        var shortestLengths = findShortestLengths(allMatches);
        if (shortestLengths.length > 1) {
            shortestLengths.sort();
            return shortestLengths[0];
        }
        else {
            return shortestLengths[0];
        }
    }
}

function findShortestLengths(arr) {
    var shortestLengths = [];

    // sorting the array by element lengths
    arr.sort(function (a, b) {
            return a.length - b.length;
        }
    );
    var shortest = arr[0].length;
    for (var i = 0; i < arr.length; i++) {
        if (shortest === arr[i].length) {
            shortestLengths.push(arr[i]);
        }
    }
    return shortestLengths;
}


autoComplete(
    [
        "GET POST if getMemory reset rebuild recap resit",
        "re",
        "res",
        "getMEM",
        "get",
        "GeT",
        "GETTER",
        "go",
        "IF",
        "getmem",
        "r",
        "rec"
]

);