$.fn.grid = function () {

	var $this = $(this);

	var addHeader = function (arr) {
		var $out = $('<tr>');

		arr.forEach(function (el) {
			var $th = $('<th>').text(el);
			$th.appendTo($out);
		});

		$out.appendTo($this);
	};

	var addRow = function (arr) {
	 	var $out = $('<tr>');

	 	arr.forEach(function (el) {
	 		var $td = $('<td>').text(el);
	 		$td.appendTo($out);
	 	});

	 	$out.appendTo($this);
	}

	return {
		addHeader: addHeader,
		addRow: addRow
	}
};
