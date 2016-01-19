var displayNextImage, displayPreviousImage, images, x;

x = -1;

images = [];

displayNextImage = function() {
  if (x === images.length - 1) {
    x = 0;
  } else {
    x = x + 1;
  }
  document.getElementById("current").src = images[x];
};

displayPreviousImage = function() {
  if (x <= 0) {
    x = images.length - 1;
  } else {
    x = x - 1;
  }
  document.getElementById("current").src = images[x];
};

images[0] = "images/1.jpg";

images[1] = "images/2.jpg";

images[2] = "images/3.jpg";

images[3] = "images/4.jpg";
