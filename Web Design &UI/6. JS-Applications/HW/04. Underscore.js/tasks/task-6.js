/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (books) {
	  var authors = [],
        maxNumberOfBooks = 1;
    _.chain(books).map(function(item){
      item.author.fullName = item.author.firstName + ' ' + item.author.lastName;
      item.authorName = item.author.fullName;
      return item;
    }).sortBy('authorName').groupBy('authorName').each(function(value, key){
      authors.push([key, value.length]);
    })
    authors = _.chain(authors).sortBy(function(item){
      return item[0];
    }).sortBy(function(item){
      return -item[1];
    }).value();
    maxNumberOfBooks = authors[0][1];
    _.chain(authors).filter(function(item){
      return item[1] === maxNumberOfBooks;
    }).each(function(item){
      console.log(item[0]);
    });
  };
}

module.exports = solve;
