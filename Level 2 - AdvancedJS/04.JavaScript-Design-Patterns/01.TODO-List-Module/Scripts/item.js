var Item = (function () {
	var id = 0;

	function Item(content, listItems) {
		this.content = content;
		this.status = 'not-completed';
		this.listItems = listItems;
		this.id = id++;
	}

	Item.prototype.addToDOM = function () {
		var _this = this;

		var $li = $('<li>'),
			$checkBox = $('<input>').attr('type', 'checkbox').attr('id', 'item' + this.id),
			$label = $('<label>').attr('for', 'item' + this.id).text(this.content),
			$removeDiv = $('<div>'),
			$removeBtn = $('<button>').text('X').hide();
			
		$removeDiv.append($removeBtn);

		$li.append($checkBox);
		$li.append($label);
		$li.append($removeDiv);

		$li.fadeIn('slow');

		this.listItems.append($li);

		$removeBtn.on('click', function () {
			$li.fadeOut('slow', function () {
				$li.remove();
			});
		});

		$li.on('click', function () {
			if($checkBox.is(':checked')) {
				$checkBox.prop('checked', false);
			} else {
				$checkBox.prop('checked', true);
			}

			if($checkBox.is(':checked')) {
				$li.css('background-color', 'rgba(0, 255, 0 , 0.5)');
				changeStatus('completed', _this);
			} else {
				$li.css('background-color', 'rgba(255, 174, 26 , 1)');
				changeStatus('not-completed', _this);
			}
		});

		$li.mouseenter(function () {
			$removeBtn.fadeIn('slow');
			$removeBtn.show();
		});

		$li.mouseleave(function () {
			$removeBtn.fadeOut('slow', function () {
				$removeBtn.hide();
			});
		});
	} 

	function changeStatus (status, item) {
		if (status === 'not-completed' || status === 'completed') {
			item.status = status;
		}
	}

	return Item;
})();