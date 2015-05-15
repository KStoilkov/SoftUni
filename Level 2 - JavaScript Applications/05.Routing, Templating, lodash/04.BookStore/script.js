$(document).ready(function () {
    var books = [
            {"book":"The Grapes of Wrath","author":"John Steinbeck","price":"34,24","language":"French"},
            {"book":"The Great Gatsby","author":"F. Scott Fitzgerald","price":"39,26","language":"English"},
            {"book":"Nineteen Eighty-Four","author":"George Orwell","price":"15,39","language":"English"},
            {"book":"Ulysses","author":"James Joyce","price":"23,26","language":"German"},
            {"book":"Lolita","author":"Vladimir Nabokov","price":"14,19","language":"German"},
            {"book":"Catch-22","author":"Joseph Heller","price":"47,89","language":"German"},
            {"book":"The Catcher in the Rye","author":"J. D. Salinger","price":"25,16","language":"English"},
            {"book":"Beloved","author":"Toni Morrison","price":"48,61","language":"French"},
            {"book":"Of Mice and Men","author":"John Steinbeck","price":"29,81","language":"Bulgarian"},
            {"book":"Animal Farm","author":"George Orwell","price":"38,42","language":"English"},
            {"book":"Finnegans Wake","author":"James Joyce","price":"29,59","language":"English"},
            {"book":"The Grapes of Wrath","author":"John Steinbeck","price":"42,94","language":"English"}
        ];


    groupBooks();
    getAverageBookPriceForAuthor();
    getBooks();

    // #1
    function groupBooks() {
        var groupedBooks = _.groupBy(books, 'language');
        for(var lang in groupedBooks) {
            groupedBooks[lang] = _.sortByAll(groupedBooks[lang], ['author', 'price'], _.values);
        }

        console.log(groupedBooks);
    }

    // #2
    function getAverageBookPriceForAuthor() {
        var groupedByAuthor = _.groupBy(books, 'author');

        for(var author in groupedByAuthor) {
            var booksLength = groupedByAuthor[author].length,
                allBooksPrice = 0.00,
                avgPrice = 0.00;

            groupedByAuthor[author].forEach(function (book) {
                var price = book['price'].replace(',', '.');
                allBooksPrice += parseFloat(price);
            });

            avgPrice = (allBooksPrice / booksLength).toFixed(2);
            groupedByAuthor[author] = avgPrice;
        }

        console.log(groupedByAuthor);
    }

    // #3
    function getBooks() {
        var booksInEnglishAndGerman = _.filter(books, function(book) {
            var meetsLang = book.language === 'English' || book.language === 'German';
            var priceIsBelow30 = parseFloat(book.price.replace(',', '.')) < 30.00;

            return meetsLang && priceIsBelow30;
        });

        console.log(_.groupBy(booksInEnglishAndGerman, 'author'));
    }
});