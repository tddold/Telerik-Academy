
function solve() {
    return function (selector) {

        var container = $('<div />').addClass('dropdown-list'),
            div = $('<div class="options-container" style="position: absolute; display: none;">'),
            numberOfOptions = $(selector).find('option').size(),
            options = $(selector).find('option'),
            i;


        $(selector).css('display', 'none').appendTo(container);
        $('<div class="current" data-value="">Option 1</div>').appendTo(container);
        for (i = 0; i < numberOfOptions; i += 1) {
            $('<div class="dropdown-item" data-value="' + $(options[i]).val() + '" data-index="' + i + '">Option' + (i + 1) + '</div>').appendTo(div);
        }

        div.appendTo(container);

        $(document.body).append(container);

        $('.current').on('click', function () {
            div.css('display', 'block');
            $(this).html('Select a value');
        });


        div.on('click', '.dropdown-item', function () {
            div.css('display', 'none');
            $(selector).val($(this).attr('data-value'));
            $('.current').html($(this).html());
        });

        return this;
    };
}

module.exports = solve;