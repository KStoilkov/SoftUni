var Container = (function () {
	function Container(title) {
		this.title = title;
		this.sections = [];

		return this;
	}

	Container.prototype.addToDOM = function () {
		var _this = this;

		var $div = $('<div>'),
			$name = $('<h1>').text(this.title),
			$sectionsDiv = $('<div>').addClass('section'),
			$newSectionInput = $('<input type="text">').addClass('section-input'),
			$newSectionBtn = $('<button>').text('New Section'),
			$removeBtn = $('<button>').addClass('containerRemoveBtn').text('X').hide();

		$div.append($name);
		$div.append($removeBtn);
		$div.append($sectionsDiv);
		$div.append($newSectionInput);
		$div.append($newSectionBtn);

		$div.fadeIn('slow');
		$('#container-wrapper').append($div);

		$newSectionBtn.on('click', function () {
			if ($newSectionInput.val().length <= 0) {
				var error = 'This field cannot be empty!',
					$h3 = $('<h3>').text(error)
								   .css('color', 'red')
								   .css('font-size', '16px')
								   .css('display', 'inline-block')
								   .css('padding', '0')
								   .css('margin', '0');

				$div.append($h3);

				setInterval(function () {
					$h3.remove();
				}, 2000);

				throw error;
			}

			var section = new Section($newSectionInput.val(), $sectionsDiv);
			section.addToDOM();

			_this.sections.push(section);

			$newSectionInput.val('');
		});

		$div.mouseenter(function () {
			$removeBtn.fadeIn('slow');
			$removeBtn.show();
		});

		$div.mouseleave(function () {
			$removeBtn.fadeOut('slow', function () {
				$removeBtn.hide();	
			});
		});

		$removeBtn.on('click', function () {
			$div.fadeOut('slow', function () {
				$div.remove();
			});
		});
	}

	return Container;
})();
