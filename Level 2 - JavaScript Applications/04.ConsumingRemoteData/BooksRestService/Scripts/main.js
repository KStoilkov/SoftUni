var bookApp = bookApp || {};

$(document).ready(function () {
	var manager = new bookApp.BookManager();
	
	addNewBookListener();

	manager.loadBooks();

	function addNewBookListener() {
		$('#newBookBtn').click(function () {
			var title = $('#newBookTitle').val(),
				author = $('#newBookAuthor').val(),
				isbn = $('#newBookISBN').val();

			manager.createBook(title, author, isbn);
		});
	}
});