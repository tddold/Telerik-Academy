(function () {
    window.onload = function () {

        var canvas = document.getElementById("ball-canvas"),
            ctx = canvas.getContext('2d'),
            direction = {
                x: 'right',
                y: 'down'
            },
            directions = {
                'left': -1,
                'right': +1,
                'up': -1,
                'down': +1
            },
            ball,
            balls;


        balls = (function () {
            var balls = Object.create({});

            Object.defineProperties(balls, {
                init: {
                    value: function (x, y, radius, speed, direction) {
                        this.x = x;
                        this.y = y;
                        this.radius = radius;
                        this.speed = speed;
                        this.direction = direction;
                        return this;
                    }
                },
                draw: {
                    value: function (ctx) {
                        ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
                        ctx.beginPath();
                        ctx.arc(this.x, this.y, this.radius, 0, 2 * Math.PI);
                        ctx.stroke();
                    }
                },
                move: {
                    value: function () {
                        this.x += this.speed * directions[this.direction.x];
                        this.y += this.speed * directions[this.direction.y];

                    }
                },
                dir: {
                    value: function (maxX, maxY) {
                        if (this.x < 0) {
                            direction.x = 'right';
                        }

                        if (this.x > maxX) {
                            direction.x = 'left';
                        }

                        if (this.y < 0) {
                            direction.x = 'down';
                        }

                        if (this.y > maxY) {
                            direction.x = 'up';
                        }
                    }
                }
            });

            return balls;
        }());

        ball = Object.create(balls)
            .init(60, 60, 15, 5, direction);

        function animationFrame() {
            ball.dir(ctx.canvas.width, ctx.canvas.height);
            ball.move();
            ball.draw(ctx);


            requestAnimationFrame(animationFrame)
        }

        requestAnimationFrame(animationFrame)


    }
}());

