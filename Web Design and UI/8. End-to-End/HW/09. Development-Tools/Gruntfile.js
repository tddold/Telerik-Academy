module.exports = function(grunt) {
    grunt.initConfig({
        project: {
            app: 'APP'
        },
        connect: {
            options: {
                port: 9578,
                livereload: 35729,
                hostname: 'localhost'
            },
            livereload: {
                options: {
                    open: true,
                    base: [
                        'DEV'
                    ]
                }
            }
        },
        watch: {
            js: {
                files: ['Gruntfile.js', 'DEV/scripts/*.js'],
                tasks: ['jshint'],
                options: {
                    livereload: true
                }
            },
            coffee: {
                files: ['<%= project.app %>/**/*.coffee'],
                tasks: ['coffee'],
                options: {
                    livereload: true
                }
            },
            styles: {
                files: ['<%= project.app %>/**/*.styl'],
                tasks: ['stylus'],
                options: {
                    livereload: true
                }
            },
            jade: {
                files: ['<%= project.app %>/**/*.jade'],
                tasks: ['jade'],
                options: {
                    livereload: true
                }
            },
            html: {
                files: ['DEV/**/*.html'],
                options: {
                    livereload: true
                }
            },
            livereload: {
                options: {
                    livereload: '<%= connect.options.livereload %>'
                },
                files: [
                    'DEV/*.html',
                    'DEV/scripts/*.js',
                    'DEV/styles/*.css'
                ]
            }
        },
        coffee: {
            compile: {
                options: {
                    bare: true
                },
                files: {
                    'DEV/scripts/scripts.js': 'APP/scripts.coffee'
                }
            }
        },
        jshint: {
            all: ['Gruntfile.js', 'DEV/scripts/**/*.js']
        },
        stylus: {
            compile: {
                options: {
                    compress: false
                },
                files: {
                    'DEV/styles/styles.css': 'APP/styles.styl'
                }
            }
        },
        jade: {
            compile: {
                options: {
                    pretty: true
                },
                files: {
                    'DEV/index.html': 'APP/index.jade'
                }
            }
        },
        copy: {
            main: {
                files: [{
                    expand: true,
                    cwd: 'APP/images',
                    src: '**/*',
                    dest: 'DEV/images'
                }, {
                    expand: true,
                    cwd: 'APP/images',
                    src: '**/*',
                    dest: 'DIST/images'
                }]
            }
        },
        csslint: {
            app: ['DEV/styles/*.css']
        },
        concat: {
            js: {
                files: {
                    'DIST/scripts/build.js': ['DEV/scripts/**/*.js']
                }
            },
            css: {
                files: {
                    'DIST/styles/build.css': ['DEV/styles/**/*.css']
                }
            }
        },
        uglify: {
            js: {
                files: {
                    'DIST/scripts/build.min.js': 'DIST/scripts/build.js'
                }
            }
        },
        cssmin: {
            css: {
                files: {
                    'DIST/styles/build.min.css': 'DIST/styles/build.css'
                }
            }
        },
        htmlmin: {
            dist: {
                options: {
                    removeComments: true,
                    collapseWhitespace: true
                },
                files: {
                    'DIST/index.html': 'DEV/index.html'
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-coffee');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-stylus');
    grunt.loadNpmTasks('grunt-contrib-jade');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-connect');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-csslint');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-htmlmin');

    grunt.registerTask('default', ['coffee', 'jshint', 'stylus', 'jade', 'copy', 'connect', 'watch']);
    grunt.registerTask('build', ['coffee', 'jshint', 'stylus', 'jade', 'csslint', 'concat', 'uglify', 'cssmin', 'htmlmin', 'copy']);
};
