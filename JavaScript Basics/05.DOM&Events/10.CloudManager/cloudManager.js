function cloud (arr) {
    var input = [];
    for (var i = 0; i < arr.length; i++) {
        input.push(arr[i].split(' '));
    }
    var result = {};
    for (i = 0; i < input.length; i++) {
        var file = input[i][0];
        var ext = input[i][1];
        var size = parseFloat(input[i][2].substring(0, input[i][2].length - 2));
        if (!result[ext]) {
            result[ext] = {};
        }
        if (!result[ext]['files']) {
            result[ext]['files'] = [];
        }
        if (result[ext]['files'].indexOf(file) === -1) {
            result[ext]['files'].push(file);

        }
        result[ext]['files'].sort();
        if (!result[ext]['memory']) {
            result[ext]['memory'] = '0';
        }
        if (result[ext]['files'].indexOf(file) >= 0) {
            result[ext]['memory'] = parseFloat(result[ext]['memory']) + parseFloat(size);
            result[ext]['memory'] = result[ext]['memory'].toFixed(2);
        }
        result[ext]['memory'] = result[ext]['memory'] + '';
    }

    for (i = 0; i < result.length; i++) {
        ext = input[i][1];
    }
    var pRsult = sortObject(result);
    console.log(JSON.stringify(pRsult));
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
cloud([ 'sentinel .exe 15MB',
    'zoomIt .msi 3MB',
    'skype .exe 45MB',
    'trojanStopper .bat 23MB',
    'kindleInstaller .exe 120MB',
    'setup .msi 33.4MB',
    'winBlock .bat 1MB' ]);
