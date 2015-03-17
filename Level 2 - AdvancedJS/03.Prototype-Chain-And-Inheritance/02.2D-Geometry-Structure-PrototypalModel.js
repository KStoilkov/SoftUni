Object.prototype.extends = function(properties) {
	function F() {};
	F.prototype = Object.create(this);

	for(var prop in properties) {
		F.prototype[prop] = properties[prop];
	};

	F.prototype._super = this;
	return new F();
};

var Shapes = (function () {
	var Shape = {
	 	init: function (color) {
			this.color = color;
			return this;
		},

		toString: function () {
			return 'Color: ' + this.color;
		}
	};

	var Circle = Shape.extends({
	    init: function Circle(color, Ox, Oy, radius) {
			this._super.init.call(this, color);
			this.Ox = Oy;
			this.Oy = Oy;
			this.radius = radius;
			return this;
		},

		toString: function () {
			return 'Circle, ' + this._super.toString.call(this) + ', O(' + this.Ox + 
				', ' + this.Oy + '), radius: ' + this.radius;
		}
	});

	var Rectangle = Shape.extends({
		init: function(color, x, y, width, height) {
			this._super.init.call(this, color);
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			return this;
		},

		toString: function () {
			return 'Rectangle, ' + this._super.toString.call(this) + ', X: ' + this.x + 
			', Y: ' + this.y + ', Width: ' + this.width + ', Height: ' + this.height;
		}
	});

	var Triangle = Shape.extends({
		init: function (color, Ax, Ay, Bx, By, Cx, Cy) {
			this._super.init.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
			this.Cx = Cx;
			this.Cy = Cy;
			return this;
		},

		toString: function () {
			return 'Triangle, ' + this._super.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + '), ' + 
				'C(' + this.Cx + ', ' + this.Cy + ')';
		}
	});

	var Line = Shape.extends({
		init: function (color, Ax, Ay, Bx, By) {
			this._super.init.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
			return this;
		},

		toString: function () {
			return 'Line, ' + this._super.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + ')';
		}
	});

	var Segment = Shape.extends({
		init: function (color, Ax, Ay, Bx, By) {
			this._super.init.call(this, color);
			this.Ax = Ax;
			this.Ay = Ay;
			this.Bx = Bx;
			this.By = By;
			return this;
		},

		toString: function () {
			return 'Segment, ' + this._super.toString.call(this) + ', A(' + this.Ax + 
				', ' + this.Ay + '), B(' + this.Bx + ', ' + this.By + ')';
		}
	});

	return {
		Shape: Shape,
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Line: Line,
		Segment: Segment
	};
})();


var circle = Object.create(Shapes.Circle).init('#FFFFFF', 5, 4, 3);
var rectangle = Object.create(Shapes.Rectangle).init('#00FF00', 5, 5,  2, 3);
var triangle = Object.create(Shapes.Triangle).init('#FF00FF', 5, 5, 6, 6, 3, 3);
var line = Object.create(Shapes.Line).init('#00FFFF', 2, 2, 3, 3);
var segment = Object.create(Shapes.Segment).init('#FF00FF', 3, 3, 4, 4);

console.log(circle.toString());
console.log(rectangle.toString());
console.log(triangle.toString());
console.log(line.toString());
console.log(segment.toString());