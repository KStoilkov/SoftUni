// Write a JavaScript function treeHouseCompare(arr) that accepts the following parameters:
// integers a and b. The function compares the area of the house and the area of the tree
// and returns the name of the figure with bigger area (house or tree) and the value of the
// area. Write JS program treehouse.js that compares a few houses and trees. The result
// should be printed on the console. Run the program through Node.js.

function treeHouseCompare(arr) {
    var a = arr[0];
    var b = arr[1];
    var houseArea = (a * a) + (a * (a - 1)) / 2;
    var treeArea = b * b/3 + Math.pow((b * 2) / 3, 2) * Math.PI;
    if (houseArea > treeArea) {
        return "house/" + houseArea.toFixed(2);
    }
    else
    {
        return "tree/" + treeArea.toFixed(2);
    }
}

console.log(treeHouseCompare([3, 2]));
console.log(treeHouseCompare([3, 3]));
console.log(treeHouseCompare([4, 5]));