module.export = function () {



    return function (element, contents) {
        var elem,
            firstChild,
            fragment,
            i,
            len,
            mewDiv,
            divToAdd;

        if (typeof (element) !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error("element");
        }

        if (typeof (element) === 'string') {
            elem = document.getElementById(element)
        } else {
            elem = element;
        }

        if (contents || contents.some(function (item) {
            return (typeof (item) !== 'string' && typeof (item) !== 'number');
        })) {
            throw new Error("content");
        }

        element.innerHTML = '';

        //firstChild = elem.firstChild;

        //while (elem.firstChild) {
        //    elem.removeChild(firstChild);
        //    firstChild = firstChild.nextSibling;
        //}

        newDiv = document.createElement('div');
        fragment = document.createDocumentFragment();

        for (i = 0, len=contents.length; i < len; i+=1) {
            divToAdd = newDiv.cloneNode(true);
            divToAdd.innerHTML = contents[i];
            fragment.appendChild(divToAdd);
        }

        elem.appendChild(fragment);
    };
};

var test = mod