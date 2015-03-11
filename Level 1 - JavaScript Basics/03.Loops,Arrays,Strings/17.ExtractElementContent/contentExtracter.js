function extractContent(str) {
    var temp = str.match(/>\w+</g);
    var result = "";
    for (var i = 0; i < temp.length; i++) {
        result += temp[i].substring(1, temp[i].length - 1);
    }
    return result;
}
console.log(extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));