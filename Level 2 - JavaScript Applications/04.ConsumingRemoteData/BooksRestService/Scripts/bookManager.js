var bookApp = bookApp || {};

var BookManager = (function (bookApp) {
	function BookManager() {
		this._bookUrl = 'https://api.parse.com/1/classes/Book';
		this._ajaxRequester = new bookApp.AjaxRequester();
		this._domManager = new bookApp.DomManager();
	}

	BookManager.prototype.createBook = function (title, author, isbn) {
		var _this = this,
			url = this._bookUrl,
			data = {
				'title': title,
				'author': author,
				'isbn': isbn
			},
			success = function (d) {
				data.objectId = d.objectId;
				_this._domManager.addBookToDOM(data, _this);
			}

			_this._ajaxRequester.postRequest(url, success, JSON.stringify(data));
	}

	BookManager.prototype.editBook = function (bookId, data, success) {
		var url = this._bookUrl + '/' + bookId,
			success = success,
			data = data;

		this._ajaxRequester.putRequest(url, data, success);
	}

	BookManager.prototype.deleteBook = function (bookId, success) {
		var url = this._bookUrl + '/' + bookId,
			success = success;

		this._ajaxRequester.deleteRequest(url, success);
	}

	BookManager.prototype.loadBooks = function () {
		var _this = this,
			url = this._bookUrl,
			success = function (data) {
				_this._domManager.addBooksToDOM(data.results, _this);
			}

		this._ajaxRequester.getRequest(url, success);
	}

	bookApp.BookManager = BookManager;
})(bookApp);