// Write a JavaScript function clone(obj) that accepts as parameter an object of reference
// type.  The function should return a deep copy of the object. Write a second function
// compareObjects(obj, objCopy) that compare the two objects by reference (==) and
// print on the console the output given below. Read in Internet about "deep copy"
// of an object and how to create it.

function clone(obj) {
    if (typeof (obj) == "object") {
        var newObj = {};
        for (var key in obj) {
            if (obj.hasOwnProperty(key)) {
                newObj[key] = clone(obj[key]);
            }
        }
        return newObj;
    } else {
        return obj;
    }
}

function compareObjects(obj, objCopy) {
    console.log("a == b - - > %s", obj == objCopy);
}

var a = { name: 'Pesho', age: 21, asd: { qweL: false, asd: ["ssda", 4, false] } };
var b = clone(a);
compareObjects(a, b);