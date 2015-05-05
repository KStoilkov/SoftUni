var Question = (function () {
	var id = 1;

	function Question (name, content, answers) {
		this.name = name;
		this.content = content;
		this.answers = answers;
		this.id = id++;
	}

	Question.prototype.addToDom = function (parent) {
		var $div = $('<div>').addClass('question'),
			$number = $('<h3>').text(this.id),
			$content = $('<p>').text(this.content),
			$ul = $('<ul>'),
			_this = this;

		this.answers.forEach(function (a) {
			a.addToDom($ul, _this);
		});

		$div.append($number).append($content).append($ul);

		$div.appendTo(parent);
	}

	Question.prototype.getName = function () {
		return this.name;	
	}

	Question.prototype.getAnswers = function () {
		return this.answers;
	}

	Question.prototype.getId = function () {
		return this.name + this.id;
	}

	return Question;
})();