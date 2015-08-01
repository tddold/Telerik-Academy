(function () {
	var log = console.log;

	function traverseElement(element, ident) {
		var child = element.firstChild,
			content;

		if (element.nodeName == "#text") {
			content = element.textContent.trimChars("\n \t");
			if (content) {
				log(ident + content);
			}
		} else {
			log(ident + "start of : " + element.nodeName);
			while (child) {
				traverseElement(child, ident + "--");
				child = child.nextSibling;
			}

			log(ident + "end of : " + element.nedeName);
		}
	}
} ());