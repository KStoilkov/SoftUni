$(document).ready(function (argument) {
	load();
	increaseLoads();	

	function load () {
		if (!sessionStorage.name) { // It works correct with localStorage too.
			var $input = $('<input>')
							.attr('type', 'text')
							.attr('placeholder', 'Your name here.'),
				$btn = $('<button>')
							.text('Enter');

			$('body').append($input).append($btn);

			$btn.on('click', function () {
				if ($input.val().length < 1) {
					throw 'This field cannot be empty';
				}

				sessionStorage.setItem('name', $input.val()); 
			});
		} else {
			var $h1 = $('<h1>')
						.appendTo('body')
						.text('Welcome back ' + sessionStorage.name);

			$('body').append($h1);
		}
	}

	function increaseLoads () {
		if (!sessionStorage.counter) {
			sessionStorage.setItem('counter', 0);
		}

		if (!localStorage.totalCounter) {
			localStorage.setItem('totalCounter', 0);
		}

		sessionStorage.counter++;
		localStorage.totalCounter++;

		var $curr = $('<h2>').text('current counter: ' + sessionStorage.counter),
			$total = $('<h2>').text('total counter: ' + localStorage.totalCounter);

		$('body').append($curr).append($total);
	}
});