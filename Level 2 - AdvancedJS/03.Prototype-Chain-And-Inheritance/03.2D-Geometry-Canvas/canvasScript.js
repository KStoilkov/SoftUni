var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');

Object.prototype.extends = function(properties) {
	function F() {};
	F.prototype = Object.create(this);

	for(var prop in properties) {
		F.prototype[prop] = properties[prop];
	};

	F.prototype._super = this;
	return new F();
};

function areValidArgs(arguments) {
	var i;
	var len = arguments.length;

	for (i = 1; i < len; i += 1) {	
		if (typeof(arguments[i]) !== 'number' || arguments[i] <= 0) {
			return false;
		}
	}

	return true;
}

function isValidHexColor(color) {
	if (color.charAt(0) !== '#') {
		return false;
	};

	var i;
	var len = color.length;
	var allowedSymbols  = 
	['0', '1', '2', '3', '4', '5', '6', '7',
	'8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

	for (i = 1; i < len; i += 1) {
		if (allowedSymbols.indexOf(color[i].toUpperCase()) === -1) {
			return false;
		}
	};

	return true;
}

var Shapes = (function () {
	var Shape = {
	 	init: function (color) {
	 		if (!isValidHexColor(color)) {
	 			throw new Error('Invalid hex color.');
	 		}

			this.color = color;

			return this;
		},

		toString: function () {
			return 'Color: ' + this.color;
		},

		draw: function () {
			ctx.beginPath();
			ctx.fillStyle = this.color;
		}
	};

	var Circle = Shape.extends({
	    init: function Circle(color, Ox, Oy, radius) {
	    	if (!areValidArgs(arguments)) {
	    		throw new Error('@Circle, Input should be a positive number.');
	    	}

			this._super.init.call(this, color);
			this.Ox = Oy;
			this.Oy = Oy;
			this.radius = radius;

			return this;
		},

		toString: function () {
			return 'Circle, ' + this._super.toString.call(this) + ', O(' + this.Ox + 
				', ' + this.Oy + '), radius: ' + this.radius;
		},

		draw: function() {
			this._super.draw.call(this);
			ctx.arc(this.Ox, this.Oy, this.radius, 0, 2 * Math.PI);
			ctx.fill();
			ctx.stroke();
		}
	});

	var Rectangle = Shape.extends({
		init: function(color, x, y, width, height) {
			if (!areValidArgs(arguments)) {
	    		throw new Error('@Rectangle, Input should be a positive number.');
	    	}

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
		},

		draw: function () {
			this._super.draw.call(this);
			ctx.fillRect(this.x, this.y, this.width, this.height);
			ctx.fill();
			ctx.stroke();
		}
	});

	var Triangle = Shape.extends({
		init: function (color, Ax, Ay, Bx, By, Cx, Cy) {
			if (!areValidArgs(arguments)) {
	    		throw new Error('@Triangle, Input should be a positive number.');
	    	}

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
		},

		draw: function() {
			this._super.draw.call(this);
			ctx.moveTo(this.Ax, this.Ay);
			ctx.lineTo(this.Bx, this.By);
			ctx.lineTo(this.Cx, this.Cy);
			ctx.fill();
			ctx.stroke();
		}
	});

	var Line = Shape.extends({
		init: function (color, Ax, Ay, Bx, By) {
			if (!areValidArgs(arguments)) {
	    		throw new Error('@Line, Input should be a positive number.');
	    	}

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
		},

		draw: function() {
			this._super.draw.call(this);
			ctx.moveTo(this.Ax, this.Ay);
			ctx.lineTo(this.Bx, this.By);
			ctx.fill();
			ctx.stroke();
		}
	});

	var Segment = Shape.extends({
		init: function (color, Ax, Ay, Bx, By) {
			if (!areValidArgs(arguments)) {
	    		throw new Error('@Segment, Input should be a positive number.');
	    	}

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
		},

		draw: function () {
			this._super.draw.call(this);
			ctx.moveTo(this.Ax, this.Ay);
			ctx.lineTo(this.Bx, this.By);
			ctx.fill();
			ctx.stroke();
		}
	});

	return {
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Line: Line,
		Segment: Segment
	};
})();

var circle = Object.create(Shapes.Circle).init('#FFAAFF', 40, 40, 40);
var rect = Object.create(Shapes.Rectangle).init('#FFFF00',60, 80, 150, 120);
var triangle = Object.create(Shapes.Triangle).init('#0000FF', 330, 200,350, 250, 400, 210);
var line = Object.create(Shapes.Line).init('#AA2233', 350, 350, 410, 50);
var Segment = Object.create(Shapes.Segment).init('#CC00AA', 400, 400, 500, 500);
circle.draw();
rect.draw();
triangle.draw();
line.draw();
Segment.draw();