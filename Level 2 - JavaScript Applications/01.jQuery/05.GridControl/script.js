$(document).ready(function () {
	var grid = $('#myGrid').grid();

	grid.addHeader(['First Name', 'Last Name', 'Age']);
	grid.addRow(['Bay', 'Ivan', 50]);
	grid.addRow(['Kaka', 'Penka', 26]);
});
