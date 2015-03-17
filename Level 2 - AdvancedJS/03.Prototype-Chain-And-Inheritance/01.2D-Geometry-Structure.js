Object.prototype.extends = function(parent) {
	this.prototype = Object.create(parent.prototype);
	this.prototype.constructor = this;
};

var Shapes = (function () {
	var Shape = (function() {
	 	function Shape(color) {
			this.color = color;
		};

		Shape.prototype.toString = function () {
			return 'Color: ' + this.color;
		};

		return Shape;
	})();

	var Circle = (function() {
	    function Circle (color, Ox, Oy, radius) {
			Shape.call(this, color);
			this.Ox = Oy;
			this.Oy = Oy;
			this.radius = radius;
		};

		Circle.extends(Shape);

		Circle.prototype.toString = function () {
			return 'Circle, ' + Shape.prototype.toString.call(this) + ', O(' + this.Ox + 
				', ' + this.Oy + '), radius: ' + this.radius;
		};

		return Circle;
	})();

	var Rectangle = (function() {
		function Rectangle(color, x, y, width, height) {
			Shape.call(this, color);
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		};

		Rectangle.extends(Shape);

		Rectangle.prototype.toString = function () {
			return 'Rectangle, ' + Shape.prototype.toString.call(this) + ', X: ' + this.x + 
			', Y: ' + this.y + ', Width: ' + this.width + ', Height: ' + this.height;
		};

		return Rectangle;
	})();

	var Triangle = (function() {
		function Triangle(color, Ax, Ay, Bx, By, Cx, Cy) {
			Shape.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
			this.Cx = Cx;
			this.Cy = Cy;
		}

		Triangle.extends(Shape);

		Triangle.prototype.toString = function () {
			return 'Triangle, ' + Shape.prototype.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + '), ' + 
				'C(' + this.Cx + ', ' + this.Cy + ')';
		};

		return Triangle;
	})();

	var Line = (function() {
		function Line(color, Ax, Ay, Bx, By) {
			Shape.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
		}

		Line.extends(Shape);

		Line.prototype.toString = function () {
			return 'Line, ' + Shape.prototype.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + ')';
		};

		return Line;
	})();

	var Segment = (function () {
		function Segment(color, Ax, Ay, Bx, By) {
			Shape.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
		}

		Segment.extends(Shape);

		Segment.prototype.toString = function () {
			return 'Segment, ' + Shape.prototype.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + ')';
		};

		return Segment;
	})();

	return {
		Shape : Shape,
		Circle : Circle,
		Rectangle : Rectangle,
		Triangle : Triangle,
		Line : Line,
		Segment : Segment
	}
})();


var circle = new Shapes.Circle('#FFFFFF', 5, 4, 3);
var rectangle = new Shapes.Rectangle('#00FF00', 5, 5,  2, 3);
var triangle = new Shapes.Triangle('#FF00FF', 5, 5, 6, 6, 3, 3);
var line = new Shapes.Line('#00FFFF', 2, 2, 3, 3);
var segment = new Shapes.Segment('#FF00FF', 3, 3, 4, 4);

console.log(circle.toString());
console.log(rectangle.toString());
console.log(triangle.toString());
console.log(line.toString());
console.log(segment.toString());