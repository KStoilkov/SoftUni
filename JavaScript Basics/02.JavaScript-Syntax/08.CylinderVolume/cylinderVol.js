// Write a JavaScript function calcCylinderVol(arr) that accepts the following parameters:
// radius and the height of a straight circular cylinder. The function calculates the
// volume of the cylinder. Write JS program cylinderVol.js that calculates the
// volume of a few cylinders. The result should be printed on the console.
// Run the program through Node.js.

function calcCylinderVol(arr) {
    var r = arr[0];
    var h = arr[1];
    return (Math.PI * (r * r) * h).toFixed(3);
}

console.log(calcCylinderVol([2, 4]));
console.log(calcCylinderVol([5, 8]));
console.log(calcCylinderVol([12, 3]));