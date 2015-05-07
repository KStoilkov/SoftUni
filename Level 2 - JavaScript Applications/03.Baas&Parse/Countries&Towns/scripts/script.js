$(document).ready(function () {
	var $ul = $('<ul>').css('width', '300px'),
		$addCountryField = $('<input>').attr('type', 'text'),
		$addCountryBtn = $('<button>').text('Add Country');

	loadCountries();

	$addCountryBtn.click(function () {
		addCountry($addCountryField.val(), $ul);
	});

	$('#wrapper').append($ul).append($addCountryField).append($addCountryBtn);

	function loadCountries() {
		$.ajax({
			method: 'GET',
			headers: {
				'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
				'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr'
			},
			url: 'https://api.parse.com/1/classes/Country'
		}).success(function (data) {
			data.results.forEach(function (c) {
				insertCountry(c);
			});
		});
	}

	function loadTowns(objectId, li) {
		$.ajax({
			method: 'GET',
			headers: {
				'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
				'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr'
			},
			url: 'https://api.parse.com/1/classes/Town/?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + objectId + '"}}'
		}).success(function (data) {
			var $townUl = $('<ul>'),
				$newTownLi = $('<li>').addClass('town'),
				$addTownField = $('<input>')
								.attr('type', 'text')
								.appendTo($newTownLi)
								.css('width', '100px'),
				$addTownBtn = $('<button>').text('Add Town').appendTo($newTownLi);

			$addTownBtn.click(function () {
				addTown($addTownField.val(), $townUl, objectId, li);
			});

			data.results.forEach(function (t) {
				var $li = $('<li>').addClass('town'),
					$h4 = $('<h5>')
								.text(t.name)
								.appendTo($li)
								.css('display', 'inline-block')
								.css('margin', '2px'),
					$removeBtn = $('<button>')
								.text('X')
								.addClass('removeCountryBtn')
								.appendTo($li)
								.css('display', 'inline-block')
								.css('border', 'none')
								.css('color', 'red')
								.hide();

				$li.hover(function () {
					$removeBtn.show();
				}, function () {
					$removeBtn.hide();
				});

				$removeBtn.click(function () {
					$.ajax({
						method: 'DELETE',
						headers: {
							'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
							'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr',
							'Content-Type' : 'application/json'
						},
						url: 'https://api.parse.com/1/classes/Town/' + t.objectId,
					}).success(function () {
						$townUl.children().remove();
						loadTowns(objectId, li);
					});
				});

				$townUl.append($li);
			});

			$townUl.append($newTownLi);
			li.append($townUl);
		});
	}

	function addCountry(country, ul) {
		$.ajax({
			method: 'POST',
			headers: {
				'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
				'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr',
				'Content-Type' : 'application/json'
			},
			url: 'https://api.parse.com/1/classes/Country',
			data: JSON.stringify({
				'name': country
			})
		}).success(function (c) {
			$ul.children().remove();
			loadCountries();
		});
	}

	function insertCountry(country) {
		var $li = $('<li>'),
			$h4 = $('<h4>')
						.text(country.name)
						.css('display', 'inline-block')
						.appendTo($li),
			$removeBtn = $('<button>')
						.text('X')
						.addClass('removeCountryBtn')
						.appendTo($li)
						.css('display', 'inline-block')
						.css('border', 'none')
						.css('color', 'red')
						.hide();

		$h4.click(function () {
			$('.town').remove();
			loadTowns(country.objectId, $li);
		});

		$li.hover(function () {
			$removeBtn.show();
		}, function () {
			$removeBtn.hide();
		});

		$removeBtn.click(function () {
			$.ajax({
				method: 'DELETE',
				headers: {
					'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
					'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr',
					'Content-Type' : 'application/json'
				},
				url: 'https://api.parse.com/1/classes/Country/' + country.objectId,
			}).success(function () {
				$ul.children().remove();
				loadCountries();
			});
		});

		$ul.append($li);
	}

	function addTown (town, ul, objectId, li) {
		$.ajax({
			method: 'POST',
			headers: {
				'X-Parse-Application-Id' : '4mKVEcgqv5LuySQu95sOPgdBPr3OSBkwFYOQLj6B',
				'X-Parse-REST-API-Key' : 'VddfIzp6xz2HU6ZqWHWlgX2az6xymd9Jx8oHU5rr',
				'Content-Type' : 'application/json'
			},
			url: 'https://api.parse.com/1/classes/Town',
			data: JSON.stringify({
				'name': town,
				"country": { "__type": "Pointer", "className": "Country", "objectId": objectId }
			})
		}).success(function () {
			ul.children().remove();
			loadTowns(objectId, li);
		});
	}
});