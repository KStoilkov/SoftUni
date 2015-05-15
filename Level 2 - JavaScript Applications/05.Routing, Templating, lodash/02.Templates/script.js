$.get('template.html', function (template) {
	var obj = {
		ppl: [
			{'name': 'Gosho Goshov', 'jobTitle': 'Fireman', 'website' : 'http://gosho.com'},
			{'name': 'Canko Toshkov', 'jobTitle': 'Architect', 'website' : 'http://canko.com'},
			{'name': 'Minka Geleva', 'jobTitle': 'Astronomer', 'website' : 'http://minka.com'}
		]
	};

	var out = Mustache.render(template, obj);
	$('#wrapper').html(out);
});
