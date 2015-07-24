/*global windows document*/

window.onload = function () {
    'use strict'
    var path,
        rect,
        paper;
    rafael = document.getElementById('root');
    paper = Raphael(10,10,500,500)
    rect = createRect(125, 75, 185, 95, 'red');
    svg.appendChild(rect);
    path = createPath('M125 200 L500 500', 'purple');
    svg.appendChild(path);
    svg.appendChild(rect);


    function createRect(x, y, width, height) {
        var rect;
        rect = document.createElementNS(svgNameSpace, 'rect');
        rect.setAttribute('x', x);
        rect.setAttribute('y', y);
        rect.setAttribute('wdth', width);
        rect.setAttribute('height', height);
        return rect;
    }

    function createPath(points) {
        var path;
        path = document.createElementNS(svgNameSpace, 'path');
        path.setAttribute('d', points);
        path.setAttribute('stroke-width', '5');
        return path;
    }
};