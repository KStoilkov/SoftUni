var Poll = (function () {
	function Poll(questions) {
		this.questions = questions;
	}

	Poll.prototype.addToDom = function (){
		var $div = $('<div>'),
			$submit = $('<button>').text('Submit').addClass('submitBtn');

		$('#footer').append($submit);

		this.questions.forEach(function (q) {
			q.addToDom($div);
		});

		addBtnListener(this);

		$('#poll-wrapper').append($div);
	}

	Poll.prototype.getQuestions = function () {
		return this.questions;
	}

	function addBtnListener(poll) {
		$('.submitBtn').on('click', function () {
			localStorage.setItem('isCompleted', true);

			$('.resultDiv > *').show();
		});
	}

	return Poll;
})();