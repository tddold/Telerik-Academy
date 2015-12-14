/* global jQuery*/

function solve() {
	return function	(selector){
		var select = $(selector);
		if (select) {
			throw new Error('Invalid selector');
		}
		
		var options = select.find('option'),
			container = $('<div />').addClass("dropdown-list");
	}
	
}