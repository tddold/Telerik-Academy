/*Write a script that creates 5 div elements and moves them in circular path with interval of 100 milliseconds
*/

var frag = document.createDocumentFragment(),
    divElement = document.createElement('div'),
    currentDiv,
    i,
    angel,
    radius,
    COUNT = 5;

divElement.style.display = 'ínline-block';
divElement.style.width = '50px';
divElement.style.height = '50px';
divElement.style.border = '2px solid yellowgreen';
divElement.style.marginRight = '25px';
divElement.style.position = 'relative';
divElement.style.top = '200px';
divElement.style.left = '100px';

for (i = 0; i < COUNT; i += 1) {
    currentDiv = divElement.cloneNode(true);

    frag.appendChild(currentDiv);
}

document.body.appendChild(frag);

animate();

angel = 3 * Math.PI / 180;
radius = 40;

function animate() {
    var divs,
        i,
        len,
        newX,
        newY,
        current;

    divs = document.getElementsByTagName('div');
    len = divs.length;

    angel += 20 * Math.PI / 180;

    for (i = 0; i < len; i += 1) {
        current = divs[i];

       
        newX = parseInt(current.style.top, 10) + radius * Math.sin(angel);
        newY = parseInt(current.style.left, 10) + radius * Math.cos(angel);

        current.style.top = newX + 'px';
        current.style.left = newY + 'px';
    }

    setTimeout(animate, 100);
}