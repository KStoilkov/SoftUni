function sortTheTable(arr) {
    var lines = [];

    for (var i = 2; i < arr.length - 1; i++) {
        lines[i - 2] = arr[i];
    }
    var priceByLine = [];
    for (i = 0; i < lines.length; i++) {
        priceByLine[i] = findPrice(lines[i]);
    }
    var result = sortArraysTogether(priceByLine, lines);

    console.log("<table>\n<tr><th>Product</th><th>Price</th><th>Votes</th></tr>");
    for (i = 0; i < lines.length; i++) {
        console.log(result[i]);
    }
    console.log("</table>");

    function findPrice(str) {
        var entry = 0;
        var result = "";
        for (var i = 0; i < str.length - 3; i++) {
            if (str.charAt(i) + str.charAt(i + 1) +
                str.charAt(i + 2) + str.charAt(i + 3) === '<td>') {
                entry++;
                if (entry === 2) {
                    while (str.charAt(i + 4) !== '<') {
                        result += str.charAt(i + 4);
                        i++;
                    }
                    break;
                }
            }
        }
        return parseFloat(result);
    }
    function sortArraysTogether(arr1, arr2) {
        var merged = [];
        for (var i = 0; i < arr1.length; i++) {
            merged.push({'key1': arr1[i], 'key2': arr2[i]});
        }
        merged.sort(function(a, b) {
            return ((a.key1 < b.key1) ? -1 : ((a.key1 == b.key1) ? 0 : 1));
        });
        var result = [];
        for (var i = 0; i < merged.length; i++) {
            result[i] = merged[i].key2;
        }
        return result;
    }
}

sortTheTable(
    [ '<table>',
        '<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
        '<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>',
        '<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
        '<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
        '<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
        '<tr><td>Cofee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
        '</table>' ]
);