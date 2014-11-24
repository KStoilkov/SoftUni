function daggers (arr) {
    var daggerLengths = [];
    var output = [];
    for (var i = 0; i < arr.length; i++) {
        var temp = Math.floor(parseInt(arr[i]));
        if (temp > 10) {
            daggerLengths.push(temp);
        }
    }
    for (i = 0; i < daggerLengths.length; i++) {
        if (daggerLengths[i] <= 40) {
            output.push('<tr><td>'+ daggerLengths[i] +'</td><td>'+ 'dagger' + '</td><td>'+ getType(daggerLengths[i])+'</td></tr>');
        }
        else {
            output.push('<tr><td>'+ daggerLengths[i] +'</td><td>'+ 'sword' + '</td><td>'+ getType(daggerLengths[i])+'</td></tr>');
        }
    }
    console.log('<table border="1">\n<thead>\n<tr><th colspan="3">Blades</th></tr>');
    console.log('<tr><th>Length [cm]</th><th>Type</th><th>Application</th></tr>');
    console.log('</thead>\n<tbody>');
    for (i = 0; i < output.length; i++) {
        console.log(output[i]);
    }
    console.log('</tbody>\n</table>');
    function getType(len) {
        var i = 0;
        while (true) {
            switch (len) {
                case i + 1: return 'blade';
                case i + 2: return 'quite a blade';
                case i + 3: return 'pants-scraper';
                case i + 4: return 'frog-butcher';
                case i + 5: return '*rap-poker';
                case i + 6: return 'blade';
                case i + 7: return 'quite a blade';
                default: break;
            }
            i+=5;
        }
    }
}

daggers(
    ['17.8',
        '19.4',
        '13',
        '55.8',
        '126.96541651',
        '3'
    ]
);