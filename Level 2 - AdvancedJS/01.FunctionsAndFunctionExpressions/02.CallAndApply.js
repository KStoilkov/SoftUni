function printArgsInfo() {
    for(var i = 0; i < arguments.length; i++) {

        if (Array.isArray(arguments[i])) {
            console.log(arguments[i] + " (array)");
        }
        else {
            console.log(arguments[i] + " (" + typeof arguments[i] + ")");
        }
    }
}

printArgsInfo.call();
console.log();
printArgsInfo.call(null, 2, 3);
console.log();
printArgsInfo.apply();
console.log();
printArgsInfo.apply(null, [ 2, 3, 4, 5]);