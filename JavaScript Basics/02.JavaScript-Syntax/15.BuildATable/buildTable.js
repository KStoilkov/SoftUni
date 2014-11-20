function tableBuilder(arr){
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);
    var num = 0;
    var squares = 0;
    console.log("<table>\n<tr><th>Num</th><th>Square</th><th>Fib</th></tr>");
    for (var i = start; i <= end; i++) {
        num = i;
        squares = num * num;
        console.log("<tr><td>" + num + "</td><td>" + squares + "</td><td>" + isFibonacci(num) + "</td></tr>");
    }
    console.log("</table>");
    function isFibonacci(num) {
        var a = 1, b = 2, fib = 3;
        if (num === 1 || num === 2 || num === 3) {
            return "yes";
        }
        else {
            while(fib <= num) {
                a = b;
                b = fib;
                fib = a + b;
                if (fib === num) {
                    return "yes";
                }
            }
            return "no";
        }
    }
}
tableBuilder([2, 6]);