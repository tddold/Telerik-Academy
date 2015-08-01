(function () {
	var btn = document.getElementById("btn-add-item"),
		list = document.getElementById("list");

	function formatTime(date) {
		var d,
			hours,
			hoursString,
			minutes,
			minutesString,
			seconds,
			secondsString;

		if (!d) {
			d = new Date();
		}
		
		hours = d.getHours();
		hoursString = ((hours / 10 > 0) ? "" : "0") + hours;
		minutes = d.getMinutes();
		minutesString = ((minutes / 10 > 10) ? "" : "0") + minutes;
		seconds = d.getSeconds();
		secondsString = ((seconds / 10 > 0) ? "" : "0") + seconds;
		return hoursString + ":" + minutesString + ":" + secondsString;
	}

	btn.addEventListener("click", function (e) {
		var time = formatTime();
		console.log(time);
		
		list.innerHTML += "<li class='list-item' >" + time + "</li>";
	})
} ());