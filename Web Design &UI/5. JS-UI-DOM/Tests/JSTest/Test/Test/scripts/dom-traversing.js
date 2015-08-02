(function () {
	'use strict'
	var list;

	function printElementInfo(element) {
		var log = console.log.bind(console),
			i,
			len;

		log("-".repeat(100));
		log("Type of the node: " + element.nodeName);
		log("Number of child nodes: " + element.childNodes.length);
		log("child nodes: ");

		for (i = 0, len = element.childNodes.length; i < len; i += 1) {
			log("childNode at (" + i + ") position: " + element.childNodes[i].nodeName);
		}

		log("-".repeat(100));
	}
	

	list = document.getElementById("trainers-list");

	printElementInfo(list);

	printElementInfo(document.body);
} ());