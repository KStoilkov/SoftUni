Array.prototype.flatten = function() {
	var resultArr = [];

	function getArrays (arr) {
		for (var i = 0; len = arr.length, i < len; i += 1) {

			var value = arr[i];	
			if (Array.isArray(value)) {
				getArrays(value);
			} else {
				resultArr.push(value);
			}
		}
	}

	getArrays(this);
	return resultArr;
}

var array = [1, 2, 3, 4];
console.log(array.flatten());

var array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());
console.log(array); // Not changed

var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());
