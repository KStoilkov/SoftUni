function query (arr) {
    for (var i = 0; i < arr.length; i++) {
        var re = repl(arr[i]).trim();;
        var input = re.split('&');
        var temp = {};
        for (var j = 0; j < input.length; j++) {
            if (input[0].charAt(0) + input[0].charAt(1) + input[0].charAt(2) + input[0].charAt(3) === 'http') {
                var questMarkSplit = input[0].split('?');
                input[0] = questMarkSplit[1];
            }
            var keyValue = input[j].split('=');
            if (!temp[keyValue[0]]) {
                temp[keyValue[0]] = [];
            }
            temp[keyValue[0]].push(keyValue[1]);
        }

        var out = '';
        for (var property in temp) {
            out += property + '=[' + temp[property].join(', ') + ']';
        }
        console.log(out);
    }

    function repl (str) {
        var result = '';
        for (var i =0; i < str.length; i++) {
            if (str.charAt(i) === '+') {
                result += ' ';
                continue;
            }
            if (str.charAt(i) + str.charAt(i + 1) + str.charAt(i + 2) === '%20') {
                result += ' ';
                i += 2;
                continue;
            }
            else {
                result += str.charAt(i);
            }
        }
        return result;
    }
}

query([ 'login=student&password=student' ]);
console.log();
query(['field=value1&field=value2&field=value3',
    'http://example.com/over/there?name=ferret']);
console.log();
query(['foo=%20foo&value=+val&foo+=5+%20+203',
    'foo=poo%20&value=valley&dog=wow+',
    'url=https://softuni.bg/trainings/coursesinstances/details/1070',
    'https://softuni.bg/trainings.asp?trainer=nakov&course=oop&course=php']);

