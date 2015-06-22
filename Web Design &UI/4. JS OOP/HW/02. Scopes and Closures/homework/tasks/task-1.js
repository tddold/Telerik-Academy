/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        function listBooks(property) {
            var prop,
                booksToReturn = [];

            if(property){
                for(prop in property){
                    if(property.hasOwnProperty(prop)){
                        booksToReturn = books.filter(function(item){
                            return item[prop] === property[prop];
                        });
                    }
                }
            } else {
                booksToReturn = books;
            }

            return booksToReturn;
        }

        function isUniqueBookTitleAuthorIsbn(book, type) {
            var i,
                len;

            for (i = 0, len = books.length; i < len; i += 1) {
                if (book[type] === books[i][type]) {
                    return false;
                }
            }

            return true;
        }

        function checkTitleLength(name) {
            if (name.length < 2 ||
                name.length > 100) {
                throw  new Error('Book title and category name must be between 2 and 100 characters');
            }
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            }
        }

        function addBook(book) {
            var param;

            if (!book.title || !book.author || !book.isbn || !book.category) {
                throw new Error('Book is invalid');
            }

            for(param in book){
                if(typeof book[param] === 'undefined'){
                    throw new Error(param + ' cannot be undefined');
                }
            }

            if (!isUniqueBookTitleAuthorIsbn(book, 'title')) {
                throw new Error('Book title must be unique');
            }

            if (!isUniqueBookTitleAuthorIsbn(book, 'isbn')) {
                throw new Error('Book isbn must be unique');
            }

            if (typeof book.isbn !== 'string' ||
                (book.isbn.length !== 10 &&
                book.isbn.length !== 13)) {
                throw new Error('Book ISBN is an unique code that contains either 10 or 13 digits')
            }

            checkTitleLength(book.title);
            checkTitleLength(book.category);

            if (!categories[book.category]) {
                addCategory(book.category);
            }

            categories[book.category].books.push(book);

            book.ID = books.length + 1;
            books.push(book);

            return book;
        }

        function listCategories() {
            var catergoriesToReturn = [];

            for(var category in categories){
                catergoriesToReturn.push(category);
            }

            return catergoriesToReturn;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}
module.exports = solve;