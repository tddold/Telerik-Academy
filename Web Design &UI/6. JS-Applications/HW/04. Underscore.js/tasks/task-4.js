/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:

```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (animals) {
	  var i,
			len,
			groupedAnimals = _.chain(animals)
				.sortBy('species')
				.reverse()
				.groupBy(function (item) {
					return item.species;
				})
				.value();

		_.each(groupedAnimals, function (value, key) {
			value = _.chain(value)
				.sortBy('legsCount')
				.sortBy(value, 'name')
				.value();

			console.log(Array(key.length + 2).join('-'));
			console.log(key + ':');
			console.log(Array(key.length + 2).join('-'));

			len = value.length;
			for (i = 0; i < len; i += 1) {
				console.log(value[i].name + ' has ' + value[i].legsCount + ' legs');
			}
		})
  };
}

module.exports = solve;
