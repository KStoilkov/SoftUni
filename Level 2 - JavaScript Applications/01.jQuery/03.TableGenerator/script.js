$(document).ready(function () {
	$('button').on('click', function (argument) {
		var input = $('input').val(),
			data = JSON.parse(input),
			tableHeaderNames = [],
			header, 
			rows,
			$table = $('<table>').addClass('table');
		
		data.forEach(function (d) {
			Object.keys(d).forEach(function (prop) {
				if (tableHeaderNames.indexOf(prop) === -1) {
					tableHeaderNames.push(prop);
				}
			});
		});

		header = generateHeader(tableHeaderNames);
		$table.append(header);

		rows = generateRows(data, tableHeaderNames);
		rows.forEach(function (row) {
			$table.append(row);
		});

		$('body').append($table);
	});

	function generateHeader (properties) {
		var header = '<thead><tr>';

		properties.forEach(function (prop) {
			header += '<th>' + prop + '</th>';
		});

		header += '</tr></thead>';
		return header;
	}

	function generateRows (data, properties) {
		var rows = [];

		data.forEach(function (d) {
			var row = '<tr>';

		  	properties.forEach(function (th) {
		  		row += '<td>' + d[th] + '</td>';
		  	});

		  	row += '</tr>'
		  	rows.push(row);
		});

		return rows;
	}
});