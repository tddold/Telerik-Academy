var gulp = require('gulp'),
    nodemon = require('gulp-nodemon'),
    plumber = require('gulp-plumber'),
    livereload = require('gulp-livereload'),
    stylus = require('gulp-stylus');

gulp.task('stylus', function () {
    gulp.src('./public/css/*.styl')
    .pipe(plumber())
    .pipe(stylus())
    .pipe(gulp.dest('./public/css'))
    .pipe(livereload());
});

gulp.task('watch', function () {
    gulp.watch('./public/css/*.styl', ['stylus']);
});

gulp.task('develop', function () {
    livereload.listen();
    nodemon({
        script: 'server.js',
        ext: 'js coffee jade',
        stdout: false
    }).on('readable', function () {
        this.stdout.on('data', function (chunk) {
            if (/^Express server listening on port/.test(chunk)) {
                livereload.changed(__dirname);
            }
        });
        this.stdout.pipe(process.stdout);
        this.stderr.pipe(process.stderr);
    });
});

gulp.task('default', [
    'stylus',
    'develop',
    'watch'
]);
