(function () {
    var list = document.getElementById("names-list"),
        tbName = document.getElementById("tb-name"),
        addButton = document.getElementById("btn-add-name"),
        names = [],
        nameItem = document.createElement("li");

    nameItem.className = "name-item";

    function onAddNameButtonClck() {
        var name,
            i,
            index,
            node;

        name = tbName.value;

        i = 0;
        while (name > names[i]) {
            i += 1;
        }

        names.splice((i === 0) ? i : i + 1, 0, name);
        nameItem.innerHTML += name + "";
        insertAt(nameItem.cloneNode(true), list, i);
        console.log(names)
    }

    function insertAt(node, parentNode, position) {
        position = position || 0;
        var beforeNode = parentNode.childNodes[position];
        parentNode.insertBefore(node, beforeNode);
    }

    addButton.addEventListener("click", onAddNameButtonClck)

}());