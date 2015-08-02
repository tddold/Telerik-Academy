(function () {
    var generateBoxBtn;

    function onGenerateBoxesButtonClick() {
        var contentDiv = document.getElementById("content"),
            count,
            i,
            len;
        while (contentDiv.firstChild) {
            contentDiv.removeChild(contentDiv.firstChild);
        }

        count = (document.getElementById("tb-box-count").value || 5) | 0;

        for (i = 0; i < count; i+=1) {
            div = document.createElement("div");
            div.className = "colored";
            contentDiv.appendChild(div);
        }
    }

    generateBoxBtn = document.getElementById("btn-generate-boxes");
    generateBoxBtn.addEventListener("click", onGenerateBoxesButtonClick);
}());