import 'jquery';
import 'jqueryui';
import lodash from 'lodash';
import toastr from 'toastr';
import templates from 'js/templates.js';
import data from 'js/data.js';

export default{
all:function(context){
  var category = context.params.category;
    if (category) {
      category = category.toLowerCase();
    }
    var events;
    data.events.get()
      .then(function(resEvents) {
        events = resEvents.result;
        return templates.get('events');
      })
      .then(function(template) {
        var groups = _.chain(events)
          .groupBy('category')
          .map(function(events, categoryName) {
            return {
              category: categoryName,
              events: events
            };
          })
          .filter(function(group) {
            return !category || group.category.toLowerCase() === category;
          })
          .value();

        context.$element().html(template(groups));

      });
},
add:function(context){
  templates.get('event-add')
        .then(function(template) {
          context.$element().html(template());

          $('#btn-event-add').on('click', function() {
            var event = {
              title: $('#tb-event-title').val(),
              category: $('#tb-event-category').val(),
              description: $('#tb-event-desc').val(),
              date: $('#tb-event-date').val() + ' ' + $(
                '#tb-event-time').val()
            };
            toastr.info(JSON.stringify(event));
            console.log(event);
            data.events.add(event)
              .then(function(event) {
                event = event.result;
                toastr.success('Event ' + event.title + ' added!');
                context.redirect('#/events');
              });
          });
          return data.categories.get();
        }).then(function(categories) {
          $('#tb-event-category').autocomplete({
            source: categories.result
          });
          $('#tb-event-date').datepicker();
          $('#tb-event-time').timepicker({
            'timeFormat': 'H:i'
          });
        });
}




};
