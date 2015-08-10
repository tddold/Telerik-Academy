/// <reference path="C:\Users\Todor\Desktop\jQuery-Plugins\homework\homework\node_modules/jquery/dist/jquery.js" />
function solve() {
    return function (selector) {
        var selected = $(selector);
        if (!selected.is(selector)) {
            throw new Error('Invalid selector');
        }

        var i,
            childrenSelectedList = selected.children,
            numberOfChildren = childrenSelectedList.length,
            container = $('<div/>').addClass('dropdown-list'),
            div = $(' <div class="options-container" style="position: absolute; display: none;">'),
            currentDiv = $('<div class="current" data-value="">Option 1</div>'),
            numberOfOptions = selected.find('option').size(),
            options = selected.find('option'),
            curr;
              

        selected.css('display', 'none').appendTo(container);
        currentDiv.appendTo(container);

        for (i = 0; i < numberOfOptions; i += 1) {
            $('<div class="dropdown-item" data-value="' + $(options[i]).val() + '" data-index="' + i + '">Option' + (i + 1) + '</div>').appendTo(div);
        }

        div.appendTo(container);

        container.appendTo($('body'));

        curr = $('.current');
        curr.on('click', function () {
            div.css('display', 'block');
            $(this).html('Select a value');
        });

        div.on('click', '.dropdown-item', function () {
            div.css('display', 'none');
            selected.val($(this).attr('data-value'));
            $('.current').html($(this).html());
        });

        return this;
    };
}

module.exports = solve;