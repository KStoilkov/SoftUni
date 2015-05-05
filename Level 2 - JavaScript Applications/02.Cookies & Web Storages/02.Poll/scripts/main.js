$(document).ready(function () {
	var answer = new Answer('4', 'firstQuestion', false),
		answer2 = new Answer('5', 'firstQuestion', false),
		answer3 = new Answer('6', 'firstQuestion', true),
		answer4 = new Answer('7', 'firstQuestion', false),
		firstQuestionAnswers = [answer, answer2, answer3, answer4],
		firstQuestion = new Question('firstQuestion', 'How many letters contains the word "Famous" ?', firstQuestionAnswers),
		answer5 = new Answer('Not True', 'secondQuestion', true),
		answer6 = new Answer('Maybe', 'secondQuestion', false),
		answer7 = new Answer('I\'m Not sure', 'secondQuestion', false),
		answer8 = new Answer('True', 'secondQuestion', false),
		secondQuestionAnswers = [answer5, answer6, answer7, answer8],
		secondQuestion = new Question('secondQuestion', '2+2=5 ?', secondQuestionAnswers),
		answer9 = new Answer('2', 'thirdQuestion', false),
		answer10 = new Answer('3', 'thirdQuestion', true),
		answer11 = new Answer('4', 'thirdQuestion', false),
		answer12 = new Answer('5', 'thirdQuestion', false),
		thirdQuestionAnswers = [answer9, answer10, answer11, answer12],
		thirdQuestion = new Question('thirdQuestion', 'How many questions contains this Poll?', thirdQuestionAnswers),
		questions = [firstQuestion, secondQuestion, thirdQuestion],
		poll = new Poll(questions);

	loadSavedQuestions(questions);

	poll.addToDom();

	questions.forEach(function (q) {
			q.getAnswers().forEach(function (a) {
				if (localStorage.isCompleted && a.checked) {
					a.result.children().show();
				}
			});
	});	

	function loadSavedQuestions (questions) {
		questions.forEach(function (q) {
				q.getAnswers().forEach(function (a) {
					if (localStorage[a.getId()]) {
						a.setChecked(true);
					}
				});
		});	
	}
});