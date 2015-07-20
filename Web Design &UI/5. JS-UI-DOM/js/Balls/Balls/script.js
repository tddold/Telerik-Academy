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
            balls,
            count,
            i,
            len;


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
                        ctx.fillStyle = 'yellow';
                        ctx.strokeStyle = 'purple';
                        ctx.lineWidth = 2;
                        ctx.beginPath();
                        ctx.arc(this.x, this.y, this.radius, 0, 2 * Math.PI);
                        ctx.fill();
                        ctx.stroke();
                    }
                },
                add:{

                },
                move: {
                    value: function () {
                        this.x += this.speed * directions[this.direction.x];
                        this.y += this.speed * directions[this.direction.y];

                    }
                },
                dir: {
                    value: function (maxX, maxY) {
                        if (this.x < this.radius) {
                            this.direction.x = 'right';
                        }

                        if (this.x > maxX - this.radius) {
                            this.direction.x = 'left';
                        }

                        if (this.y < this.radius) {
                            this.direction.y = 'down';
                        }

                        if (this.y > maxY - this.radius) {
                            this.direction.y = 'up';
                        }
                    }
                }
            });

            return balls;
        }());

        ball = Object.create(balls)
            .init(60, 60, 10, 5, direction);

        count = 3;
        for (i = 0; i < count; i+=1) {

        }

        function animationFrame() {
            ball.dir(ctx.canvas.width, ctx.canvas.height);
            ball.move();
            ball.draw(ctx);


            requestAnimationFrame(animationFrame)
        }

        requestAnimationFrame(animationFrame)


    }
}());

