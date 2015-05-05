var Section = (function () {
	function Section(title, sectionsDiv){
		this.title = title;
		this.items = [];
		this.sectionsDiv = sectionsDiv;
	}

	Section.prototype.addToDOM = function () {
		var _this = this;

		var $div  = $('<div>').addClass('itemDiv'),
			$name = $('<h2>').text(this.title),
			$listItems = $('<ul>').addClass('list-items'),
			$addItemMenu = $('<div>').addClass('itemMenuDiv'),
			$newItemField = $('<input type="text" placeholder="Add Item">'),
			$newItemBtn = $('<button>').text('+'),
			$removeBtn = $('<button>').addClass('sectionRemoveBtn').text('X').hide();

		$addItemMenu.append($newItemField);
		$addItemMenu.append($newItemBtn);

		$div.append($removeBtn);
		$div.append($name);
		$div.append($listItems);
		$div.append($addItemMenu);

		$div.fadeIn('slow');
		this.sectionsDiv.append($div);

		$newItemBtn.on('click', function () {

			if ($newItemField.val().length <= 0) {
				var error = 'This field cannot be empty!',
					$h3 = $('<h3>').text(error)
								   .css('color', 'red')
								   .css('font-size', '12px')
								   .css('display', 'inline-block')
								   .css('padding', '0')
								   .css('margin', '0');

				$addItemMenu.prepend($h3);

				setInterval(function () {
					$h3.remove();
				}, 2000);

				throw error;
			}

			var item = new Item($newItemField.val(), $listItems);

			item.addToDOM();

			_this.items.push(item);

			$newItemField.val('');
		});

		$div.mouseenter(function () {
			$removeBtn.fadeIn('slow');
			$removeBtn.show();
		});

		$div.mouseleave(function () {
			$removeBtn.fadeOut('slow', function () {
				$removeBtn.hide();
			})
		});

		$removeBtn.on('click', function () {
			$div.fadeOut('slow', function () {
				$div.remove();
			});
		});
	}

	return Section;
})();