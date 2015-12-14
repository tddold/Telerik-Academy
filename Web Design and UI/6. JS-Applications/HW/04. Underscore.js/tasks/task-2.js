/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
	   _.chain(students)
	  .filter(function(item){
		  return (18 <= item.age && item.age <= 24);
	  })
	  .map(function (item) {
		  item.fullName = item.firstName + ' ' + item.lastName;
		  return item;
	  })
	  .sortBy('firstName')
	  .each(function(item){
		  console.log(item.fullName);
	  })
  };
}

module.exports = solve;
