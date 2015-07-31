(function () {
	var btn = document.getElementById("btn-add-item"),
		list = document.getElementById("list");

	function formatTime(date) {
		var hours,
			hoursString,
			minutes,
			minutesString,
			secods,
			secondsString;

		if (!date) {
			date = new Date();
		}

		hours = date.getHours();
		hoursString = ((hours / 10 > 0) ? "": "0") + hours;
		minutes = date.getMinutes();
		minutesString = ((minutes / 10 > 0) ? "":"0") + hours;
		secods = date.getSeconds();
		secondsString = ((secods / 10 > 0) ? "": "0") + hours;
		
		return hoursString + ":" + minutesString + ":" + secondsString;
	}
	
	btn.addEventListener("click", function(e){
		var time = formatTime();
		console.log(time);
		
		list.innerHTML += "<li class = list-item>" + time + "</li>";
	});
} ());