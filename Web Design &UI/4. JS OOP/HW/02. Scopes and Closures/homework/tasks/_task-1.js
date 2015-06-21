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
    console.log(arguments.length);
    var library = (function () {
        var books = [],
            categories = [];

        function listBooks(parameter) {
            var tempBooks = books.slice();

            if (parameter) {
                var prop;

                if(arguments.length > 0){
                    if(typeof parameter.category !== 'undefined'){
                        if(typeof categories[parameter.category] !== 'undefined'){
                            return categories[parameter.category].books;
                        } else {
                            return [];
                        }
                    }
                }

                for (prop in parameter) {
                    if (parameter.hasOwnProperty(prop)) {
                        tempBooks = books.filter(function (item) {
                            return item[prop] === parameter[prop];
                        });
                    }
                }
            }

            books = tempBooks.slice();
            return books.sort(function (a, b) {
                return a.id - b.id;
            });
        }

        function checkCategoryAndBookName(name){
            if(typeof name !== 'string' ||
                name.length <2 ||
                name.length > 100) {
                throw new Error('Book title name must be between 2 and 100 characters, including letters, digits and special characters ("!", ",", ".", etc)');
            }
        }

        function addBook(book) {
            var categoryIndex;

            if(checkBookParametarExists(book.title, 'title')){
                throw  new Error('Each book has unique title');
            }

            if(checkBookParametarExists(book.isbn, 'isbn')){
                throw  new Error('Each book has unique isbn');
            }

            //if (books.every(function (item) {
            //        return (item.title !== book.title && item.isbn !== book.isbn);
            //    })) {
            //    book.ID = books.length + 1;
            //    books.push(book);
            //} else {
            //    throw  new Error('Each book has unique title');
            //}

            if (!categories.some(function (item, index) {
                    categoryIndex = index;
                    return item.name === book.category;
                })) {
                addCategory(book.category);
            } else {
                categories[book.category].books.push(book);
            }

            if(typeof book.author !== 'string' || book.author === ''){
                throw new Error('Author mast be a non-empty string');
            }

            if(typeof book.isbn !== 'string' ||
                (book.isbn.length !== 10 && book.isbn.length !== 13)||
                 book.isbn.split('').every(function(item){
                return isNaN(item);
            })){
                throw new Error('Book ISBN is an unique code that contains either 10 or 13 digits');
            }

            checkCategoryAndBookName(book.title);
            checkCategoryAndBookName(book.category);

            book.ID = books.length + 1;
            books.push(book);

            return book;
        }

        function listCategories() {
            return categories.sort(function (a, b) {
                return a.id - b.id;
            })
                .map(function (item) {
                    return item = item.name;
                });
        }

        function addCategory(name){
            categories[name] = {
                books:[],
                ID: categories.length + 1
            }
        }

        function checkBookParametarExists(name, type){
           var i,
               len;
            for(i = 0, len = books.length; i < len; i+=1){
                if(books[i][type] === name){
                    return true;
                }
            }

            return false;
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

var books = [
    {
        "ID": 2,
        "author": "John Doe",
        "category": "Book Category",
        "isbn": "1234567890111",
        "title": "BOOK #"
    }
];

console.log(solve(books));