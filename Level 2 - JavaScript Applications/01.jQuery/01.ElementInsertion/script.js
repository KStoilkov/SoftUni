$(document).ready(function () {
	$('button').on('click', function (e) {
		var $el = $('.new-element').val();
		var $newElement = $("<" + $el + ">").text('I am ' + $el);

		if ($(e.target).hasClass('before')) {
			$('.first').before($newElement);
		}
		else if ($(e.target).hasClass('after')) {
			$('.first').after($newElement);
		}
	});
});