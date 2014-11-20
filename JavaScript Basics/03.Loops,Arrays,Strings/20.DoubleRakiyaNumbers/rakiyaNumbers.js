function rakiyaNumbers(arr) {
    var a = parseInt(arr[0]);
    var b = parseInt(arr[1]);

    console.log("<ul>");
    for (var i = a; i <= b; i++) {
        if (isRakiya(i)) {
            console.log("<li><span class='rakiya'>" + i + "</span>" +
            "<a href=\"view.php?id=" + i + ">View</a></li>"
            );
        }
        else {
            console.log("<li><span class='num'>" + i + "</span></li>");
        }
    }
    console.log("</ul>");

    function isRakiya(num) {
        var numArr = (num + "").split('');
        for (var i = 0; i < numArr.length - 1; i++) {
            var currentNum = numArr[i] + numArr[i + 1];
            for (var j = i + 2; j < numArr.length; j++) {
                if (numArr[j] + numArr[j + 1] === currentNum) {
                    return true;
                }
            }
        }
        return false;
    }
}

rakiyaNumbers(['5','8']);
console.log();
rakiyaNumbers(['11210','11215']);
console.log();
rakiyaNumbers(['55555','55560']);