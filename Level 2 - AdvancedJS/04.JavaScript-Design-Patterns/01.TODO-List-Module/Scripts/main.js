var containers = [];
$(document).ready(function () {
	var $newListButton = $('#new-list input[type=button]'),
		$newListField = $('#new-list input[type=text]');

	$newListButton.on('click', function () {

		if ($newListField.val().length <= 0) {
			var error = 'This field cannot be empty!',
				$h3 = $('<h3>').text(error)
							   .css('color', 'red')
							   .css('font-size', '18px')
							   .css('display', 'inline-block')
							   .css('padding', '0')
							   .css('margin', '0');
							   
			$('#new-list').append($h3);

			setInterval(function () {
				$h3.remove();
			}, 2000);

			throw error;
		} 

		var container = new Container($('#new-list input[type=text]').val());
		container.addToDOM();
		containers.push(container);

		$('#new-list > input[type=text]').val('');
	})
});

