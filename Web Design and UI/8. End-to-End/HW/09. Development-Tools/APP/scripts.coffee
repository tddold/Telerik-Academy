x = -1
images = []
displayNextImage = ->
  if (x is images.length - 1) then x=0 else x=x + 1
  document.getElementById("current").src = images[x]
  return
displayPreviousImage = ->
  if (x <= 0) then x=images.length - 1 else x=x - 1
  document.getElementById("current").src = images[x]
  return

images[0] = "images/1.jpg"
images[1] = "images/2.jpg"
images[2] = "images/3.jpg"
images[3] = "images/4.jpg"