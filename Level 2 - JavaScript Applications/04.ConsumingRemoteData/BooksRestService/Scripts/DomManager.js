var bookApp = bookApp || {}

var DomManager = (function (bookApp) {
	function DomManager() {
		this._parent = $('#booksWrapper');
	}

	DomManager.prototype.addBooksToDOM = function (books, bookManager) {
		var _this = this;

		books.forEach(function (book) {
			_this.addBookToDOM(book, bookManager);
		});
	}

	DomManager.prototype.addBookToDOM = function (book, bookManager) {
		var $wrapper = $('<div>').addClass('book').attr('id', book.objectId),
			$title = $('<h1>').text(book.title).appendTo($wrapper),
			$author = $('<h3>').addClass('bookAuthor').text('Author: ' + book.author).appendTo($wrapper),
			$isbn = $('<h3>').addClass('bookISBN').text('ISBN: ' + book.isbn).appendTo($wrapper);

		this._parent.append($wrapper);
		addEditButtons($wrapper, bookManager);
	}

	function addEditButtons(parent, bookManager) {
		var $div = $('<div>').addClass('editPanel'),
			$editBtn = $('<button>').text('Edit').hide().appendTo($div),
			$deleteBtn = $('<button>').text('Delete').hide().appendTo($div),
			btns = [$editBtn, $deleteBtn];

		parent.hover(function () {
			$editBtn.show();
			$deleteBtn.show();
		}, function () {
			$editBtn.hide();
			$deleteBtn.hide();
		});

		btns.forEach(function (btn) {
			btn.hover(function () {
				btn.css('box-shadow', '0 0 5px #000');
			}, function () {
				btn.css('box-shadow', '');
			});
		});

		addEditPanelBtnListeners(btns, parent, bookManager);
		parent.append($div);
	}

	function addEditPanelBtnListeners (btns, parent, bookManager) {
		btns.forEach(function (btn) {
			btn.click(function (ev) {
				if ($(ev.target).text() === 'Delete') {
					bookManager.deleteBook(parent.attr('id'), function () {
						parent.remove();
					});
				}

				if ($(ev.target).text() === 'Edit') {
					bookManager._ajaxRequester.getById(bookManager._bookUrl, parent.attr('id'), function (data) {
						addEditDiv(data.title, data.author, data.isbn, data.objectId, bookManager);
					});
				}
			});
		});
	}

	function addEditDiv(title, author, isbn, id, bookManager) {
		$('.editDiv').remove();

		var $div = $('<div>').addClass('editDiv'),
			$title = $('<input>').attr('type', 'text').attr('value', title).appendTo($div),
			$author = $('<input>').attr('type', 'text').attr('value', author).appendTo($div),
			$isbn = $('<input>').attr('type', 'text').attr('value', isbn).appendTo($div),
			$btn = $('<button>').text('Edit Book').appendTo($div);

		$btn.click(function () {
			var data = {
					'title': $title.val(),
					'author': $author.val(),
					'isbn': $isbn.val()
				},
				success = function (data) {
					$div.remove()

					$('#' + id).find('h1').text($title.val());
					$('#' + id).find('h3.bookAuthor').text('Author: ' + $author.val());
					$('#' + id).find('h3.bookISBN').text('ISBN: ' + $isbn.val());
				}

			bookManager.editBook(id, JSON.stringify(data), success);
		});

		$('#wrapper').append($div);
	}

	bookApp.DomManager = DomManager;
})(bookApp);