var testContext = function () {
    console.log(this);
};

var testThis = function () {
    testContext();
};

var test = new testContext();

testContext();
console.log();
testThis();
console.log();
console.log(test);