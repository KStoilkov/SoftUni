function pricesTrend(arr) {
    console.log("<table>");
    console.log("<tr><th>Price</th><th>Trend</th></tr>");
    var prevValue = parseFloat((parseFloat(arr[0])).toFixed(2));
    var isFirst = true;
    var img = "";
    for (var i = 0; i < arr.length; i++) {
        var value = parseFloat((parseFloat(arr[i])).toFixed(2));
        if (value === prevValue || isFirst) {
            img = '<img src="fixed.png"/>';
        }
        else if (value > prevValue) {
            img = '<img src="up.png"/>';
        }
        else if(value < prevValue) {
            img = '<img src="down.png"/>';
        }
        console.log('<tr><td>' + value.toFixed(2) + '</td><td>'+ img +'</td></td>');
        prevValue = value;
        isFirst = false;
    }
    console.log("</table>");
}

pricesTrend(['50', '60']);
console.log();
pricesTrend(['36.333',
    '36.5',
    '37.019',
    '35.4',
    '35',
    '35.001',
    '36.225'
]);