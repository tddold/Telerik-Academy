var layer = new Kinetic.Layer(),
    ball = new Kinetic.Circle({
        x: 0,
        y: 0,
        fill: 'pink',
        stroke: 'purple'
    });
console.log(ball);

layer.add(ball);
stage.add(layer);

function animFrame() {
    var x = ball.getX() + 5,
        y = ball.getY() + 10;

    ball.setX(x);
    ball.setY(y);

    layer.draw;

    setTimeout(animFrame, 300);
}
