var Answer = (function () {
	var id = 0;

	function Answer(content, questionName, isCorrect) {
		this.content = content;
		this.checked = false;
		this.isCorrect = isCorrect;
		this.id = id++ + questionName;
		this.result = $('<div>').addClass('answerResult');
	}

	Answer.prototype.addToDom = function (parentDom, parent) {
		var	$li = $('<li>'),
			$content = $('<div>').addClass('answerContent').text(this.content),
			$resultText = $('<h4>').hide();
		
		if (this.isCorrect) {
			$resultText.text('V').css('color', 'green');
		} else {
			$resultText.text('X').css('color', 'red');
		}

		if (this.checked) {
			$content.addClass('orangeDiv');
			this.result.addClass('resultDiv');
		}

		addContentDivListener(this, $content, parent, this.result);

		this.result.append($resultText);

		$li.append(this.result).append($content);	

		$li.appendTo(parentDom);
	}

	Answer.prototype.getId = function () {
		return this.id;
	}

	Answer.prototype.setChecked = function (checked) {
		this.checked = checked;
	}

	function addContentDivListener (answer, contentDiv, parent, result) {
		contentDiv.on('click', function () {
			answer.checked = !answer.checked;

			if (contentDiv.hasClass('orangeDiv')) {
				contentDiv.removeClass('orangeDiv');
				localStorage.removeItem(answer.getId());
				result.removeClass('resultDiv');

			} else {
				contentDiv.addClass('orangeDiv');
				result.addClass('resultDiv');
				localStorage.setItem(answer.getId(), true);
			}
		});
	}

	return Answer;
})();