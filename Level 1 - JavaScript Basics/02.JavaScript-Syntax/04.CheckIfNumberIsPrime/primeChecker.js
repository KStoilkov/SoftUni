// Write a JavaScript function isPrime(number) that checks if an integer number is prime.
// Write JS program primeChecker.js that checks if a few numbers are prime.
// The result should be printed on the console (true or false) on the console.
// Run the program through Node.js.

function isPrime(number) {
    if (number < 2){
        return false;
    }
    else if (number >= 2) {
        if (number === 2) {
            return true;
        }
        else {
            for (var i = 2; i <= Math.sqrt(number); i++) {
                if (number % i === 0) {
                    return false;
                }
            }
            return true;
        }

    }

}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));