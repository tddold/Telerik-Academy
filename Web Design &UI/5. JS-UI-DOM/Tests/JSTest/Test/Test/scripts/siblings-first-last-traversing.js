(function () {
    var log = console.log.bind(console),
        ul,
        bd,
        content = '';

    //function traverseElement(element, indent) {
    //    var child = element.firstChild,
    //         content;
    //    // log(element.nodeName);
    //    if (element.nodeName == "#text") {
    //        content = element.textContent.trimChars("\n \t");
    //        if (content) {
    //            log(indent + content);
    //        }
    //    } else {
    //        log(indent + "start of : " + element.nodeName);
    //        while (child) {
    //            traverseElement(child, indent + "--");
    //            child = child.nextSibling;
    //        }
    //        log(indent + "end of : " + element.nodeName);
    //    }
    //}

    //traverseElement(document, "");

    ul = document.getElementById("trainers-list");

    var container = document.getElementById("container");

    var dFrag = document.createDocumentFragment();

    for (var i = 0; i < 10; i+=1) {
        var currLi = document.createElement("li");
        currLi.innerHTML = i;
        dFrag.appendChild(currLi);
    }

    ul.appendChild(dFrag);

    container.appendChild(ul);

}());