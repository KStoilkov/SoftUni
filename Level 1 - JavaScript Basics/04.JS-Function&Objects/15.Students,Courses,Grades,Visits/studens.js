function aggregate(arr) {
    var input = [];
    var result = {};
    for (var i = 0; i < arr.length; i++) {
        input.push(arr[i].split(/[|]/));
    }

    for (i = 0; i < input.length; i++) {
        var name = input[i][0].trim();
        var course = input[i][1].trim();

        if (!result[course]) {
            result[course] = {};
        }
        if (!result[course]['avgGrade']) {
            result[course]['avgGrade'] = findAvg(course, input, 'grade')
        }
        if (!result[course]['avgVisits']) {
            result[course]['avgVisits'] = findAvg(course, input, 'visit');
        }
        if (!result[course]['students']) {
            result[course]['students'] = [];
        }
        if (result[course]['students'].indexOf(name) === -1) {
            result[course]['students'].push(name);
        }
        result[course]['students'].sort();
    }
    var pResult = sortObject(result);
    pResult = JSON.stringify(pResult);
    console.log(pResult);
    function findAvg(c, all ,vOrG){
        var sum = 0;
        var num = 0;
        for (var i = 0; i < all.length; i++) {
            var course = all[i][1].trim();
            var grade = 0;
            switch(vOrG){
                case 'grade': grade = parseFloat(all[i][2].trim()); break;
                case 'visit': grade = parseFloat(all[i][3].trim());break;
                default : break;
            }

            if (c === course) {
                sum += grade;
                num++;
            }
        }
        var result = (sum / num).toFixed(2);
        return parseFloat(result);
    }
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


aggregate(
    [ 'Peter Nikolov | PHP  | 5.50 | 8',
        'Maria Ivanova | Java | 5.83 | 7',
        'Ivan Petrov   | PHP  | 3.00 | 2',
        'Ivan Petrov   | C#   | 3.00 | 2',
        'Peter Nikolov | C#   | 5.50 | 8',
        'Maria Ivanova | C#   | 5.83 | 7',
        'Ivan Petrov   | C#   | 4.12 | 5',
        'Ivan Petrov   | PHP  | 3.10 | 2',
        'Peter Nikolov | Java | 6.00 | 9' ]
);