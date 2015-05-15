(function () {
	var router = Sammy(function () {
		var selector = '#wrapper';

		this.get('#/Bob', function () {
			var $h2 = $('<h2>').text('Hello, Bob')
			$(selector).html($h2);
		})

		this.get('#/Sam', function () {
			var $h2 = $('<h2>').text('Hello, Sam');
			$(selector).html($h2);
		});

		this.get('#/Tom', function () {
			var $h2 = $('<h2>').text('Hello, Tom');
			$(selector).html($h2);
		});
	});

	router.run('#/');
})();