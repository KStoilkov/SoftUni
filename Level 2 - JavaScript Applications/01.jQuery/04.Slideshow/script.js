$(document).ready(function () {
	$('#slide').hide();
	$('#slide').first().addClass('active');
	$('.active').show();

	$('#next, #prev').on('click', function (e) {
		var id = e.target.id;

		switch(id) {
			case 'prev': 
				goToPrev();
				break;
			case 'next': 
				goToNext();
				break;
		}
	})

	var goToPrev = function() {
		$('.active').removeClass('active').addClass('lastActive');

		if ($('.lastActive').is(':first-child')) {
			$('#slide:last-child').addClass('active');
		} else {
			$('.lastActive').prev().addClass('active');
		}

		animate();
	}

	var goToNext = function () {
		$('.active').removeClass('active').addClass('lastActive');

		if ($('.lastActive').is(':last-child')) {
			$('#slide').first().addClass('active');
		} else {
			$('.lastActive').next().addClass('active');
		}

		animate();
	}

	var animate = function () {
		$('.lastActive').removeClass('lastActive');

	 	$('#slide > img').fadeOut('slow');
	 	$('.active > img').fadeIn('slow');
	}

	setInterval(function function_name (argument) {
		goToNext();
	}, 5000);
});