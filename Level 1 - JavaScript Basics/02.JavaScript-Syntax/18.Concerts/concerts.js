function jsonConcerts(arr) {
    var concerts = {};
    for (var i = 0; i < arr.length; i++) {
        var input = arr[i].split(/[^0-9A-Za-z]+ /);
        var city = input[1];
        var place = input[3];

        if (!concerts[city]) {
            concerts[city] = {};
        }
        if (!concerts[city][place]) {
            concerts[city][place] = [];
        }
        if (concerts[city][place].indexOf(input[0]) === -1) {
            concerts[city][place].push(input[0]);
        }
        concerts[city][place].sort();
    }
    concerts = sortObject(concerts);
    for (var c in concerts) {
        concerts[c] = sortObject(concerts[c]);
    }
    var result = JSON.stringify(concerts);
    console.log(result);
    function sortObject(obj) {
            var keys = Object.keys(obj).sort();
            var sorted = {};

            for (var i = 0; i < keys.length; i++) {
                var key = keys[i];
                sorted[key] = obj[key];
            }

            return sorted;

        }
}
jsonConcerts(
    [ 'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
        'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
        'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
        'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
        'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
        'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
        'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
        'Helloween | London | 28-Jul-2014 | Wembley Stadium',
        'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
        'Metallica | London | 03-Oct-2014 | Olympic Stadium',
        'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
        'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium' ]
);