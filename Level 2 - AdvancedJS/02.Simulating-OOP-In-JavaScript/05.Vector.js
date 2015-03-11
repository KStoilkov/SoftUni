var Vector = (function () {
	function Vector () {
		if (arguments.length === 0 || arguments[0].length === 0) {
			throw ("Vector should contain atleast one number");
		};

		this.dimension = arguments[0].length;
		this.values = arguments[0];
	};

	return Vector;
})();

Vector.prototype =  {
	add: function(other) {
		this.validateDimensions(other);

		var resultValues = [];
		for (var i = 0; len = other.values.length, i < len; i += 1) {
			resultValues.push(this.values[i] + other.values[i]);
		};

		return new Vector(resultValues);
	},
	subtract: function(other) {
		this.validateDimensions(other);

		var resultValues = [];
		for (var i = 0; len = other.values.length, i < len; i += 1) {
			resultValues.push(this.values[i] - other.values[i]);
		}

		return new Vector(resultValues);
	},
	dot: function(other) {
		this.validateDimensions(other);

		var result = 0;
		for(var i = 0; len = other.values.length, i < len; i += 1) {
			result += this.values[i] * other.values[i];
		}	

		return result;
	},
	norm: function() {
		var result = 0;

		for(var i = 0; len = this.values.length, i < len; i += 1) {
			result += this.values[i] * this.values[i];
		}

		return Math.sqrt(result);
	},
	toString: function() {
		var result = "(";

		for(var i = 0; len = this.values.length, i < len; i += 1) {
			result += this.values[i];
			
			if (i !== len-1) {
				result += ", ";
			};
		}

		result += ")";
		return result;
	},
	validateDimensions: function(other) {
		if (this.dimension !== other.dimension) {
			throw ("Vectors dimensions should be equals.");
		};
	}
}

var a = new Vector([1, 2, 3]);
var b = new Vector([4, 5, 6]);
var c = new Vector([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]);
var result = a.add(b);
console.log(result.toString());
result = a.subtract(b);
console.log(result.toString());
result = a.dot(b);
console.log(result.toString());
console.log(a.norm());
console.log(b.norm());
console.log(c.norm());
console.log(a.add(b).norm());

// The following throw errors
// var wrong = new Vector();
// var anotherWrong = new Vector([]);
// a.add(c); 
// a.subtract(c);
// a.dot(c); 