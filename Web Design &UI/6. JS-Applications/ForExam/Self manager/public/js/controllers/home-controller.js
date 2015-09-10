import 'jquery';
import templates from 'js/templates.js';

export default {
	all: function(context) {
		templates.get('home')
			.then(function(template) {
				context.$element().html(template());
			});
	}
};
