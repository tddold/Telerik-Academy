/* globals $ */

/* 
Create a function that takes an id or DOM element and:

    If an id is provided, select the element
    Finds all elements with class button or content within the provided element
        Change the content of all .button elements with "hide"
    When a .button is clicked:
        Find the topmost .content element, that is before another .button and:
            If the .content is visible:
                Hide the .content
                Change the content of the .button to "show"
            If the .content is hidden:
                Show the .content
                Change the content of the .button to "hide"
            If there isn't a .content element after the clicked .button and before other .button, do nothing
    Throws if:
        The provided DOM element is non-existant
        The id is either not a string or does not select any DOM element 
*/

// Validators--------------------------------------------
var validator = {
    validateExistingId: function (id) {
        if (!isExistingId(id)) {
            throw new Error("The provide id dose not select.")
        }
    },
    validateParams: function (selector) {
        if (!isString(selector) && !isHTMLElement(selector)) {
            throw new Error('The provided id is not a string or dose not selected any DOM element');
        }
    }
};

function isHTMLElement(obj) {
    return typeof (obj) === 'object' && obj instanceof Element;
}

function isString(obj) {
    return typeof (obj) === 'string' || obj instanceof String;
}

function isExistingId(id) {
    var element = document.getElementById(id);
    return typeof (element) !== undefined && element !== null;
}

// Validators--------------------------------------------


function solve() {
    return function (selector) {
        var i,
            len,
            currButton,
            onButtonClick;

        validator.validateParams(selector);
        validator.validateExistingId(selector);

        var buttons = document.getElementsByClassName('button');
        len = buttons.length;
        for (i = 0; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
        }

        for (i = 0; i < len; i += 1) {
            currButton = buttons[i];

            currButton.addEventListener("click", onButtonClick, false);

            onButtonClick = function (ev) {
                var clickedButton,
                    nextContent,
                    isContentVisible;

                clickedButton = ev.target;
                nextContent = clickedButton.nextElementSibling;

                while (nextContent && nextContent.className.indexOf('content') < 0) {
                    nextContent = nextContent.nextElementSibling;
                }

                isContentVisible = nextContent.style.display === '';

                if (isContentVisible) {
                    nextContent.style.display = 'none';
                    clickedButton.innerHTML = 'show';
                } else {
                    nextContent.style.display = '';
                    clickedButton.innerHTML = 'hide';
                }

            }
        }
    };
};

module.exports = solve;