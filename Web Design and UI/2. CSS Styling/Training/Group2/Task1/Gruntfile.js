module.exports = function(grunt) {
  grunt.initConfig({
    watch: {
      livereload: {
        files: ['**/*.html', '**/*.css'],
        options: {
          livereload: true
        }
      }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.registerTask('default', 'watch');
}