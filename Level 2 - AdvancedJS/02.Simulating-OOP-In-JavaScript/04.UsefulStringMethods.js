String.prototype.startsWith = function(substring) {
	var inputSubstring = this.substring(0, substring.length);	

	if (inputSubstring.length === substring.length && 
		inputSubstring === substring) {
		return true;
	};

	return false;
};

String.prototype.endsWith = function(substring) {
	var inputSubstring = this.substring(this.length - substring.length, this.length);

	if (inputSubstring.length === substring.length &&
		inputSubstring === substring) {
		return true;
	};

	return false;
};

String.prototype.left = function(count) {
	return this.substring(0, count);
};

String.prototype.right = function(count) {
	return this.substring(this.length - count, this.length);
};

String.prototype.padLeft = function(count, character) {
	var result = "";

	if (character === undefined) {
		character = " ";
	};

	for(var i = 0; i < count; i += 1) {
		result += character;
	}

	return result + this;
};

String.prototype.padRight = function(count, character) {
	var result = this;

	if (character === undefined) {
		character = " ";
	};

	for (var i = 0; i < count; i += 1) {
		result += character;
	};

	return result;
};

String.prototype.repeat = function(count) {
	var result = "";

	for (var i = 0; i < count; i++) {
		result += this;
	};

	return result;
};

var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.endsWith("poses."));
console.log(example.left(9));
console.log(example.left(90));
console.log(example.right(9));
console.log(example.right(90));
var example = "abcdefgh";
console.log(example.left(5).right(2));
var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
console.log("*".repeat(5));
console.log("~".repeat(3));
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));
