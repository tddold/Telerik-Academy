// Karma configuration
// Generated on Thu Sep 25 2014 11:52:02 GMT-0700 (PDT)
var file2moduleName = require('./tools/build/file2modulename');

module.exports = function(config) {
  config.set({

    frameworks: ['dart-unittest'],

    files: [
      // Init and configure guiness.
      {pattern: 'test-init.dart', included: true},
      // Unit test files needs to be included.
      // Karma-dart generates `__adapter_unittest.dart` that imports these files.
      {pattern: 'modules/*/test/**/*_spec.js', included: true},
      {pattern: 'modules/*/test/**/*_spec.dart', included: true},
      {pattern: 'tools/transpiler/spec/**/*_spec.js', included: true},

      // These files are not included, they are imported by the unit tests above.
      {pattern: 'modules/**', included: false},
      {pattern: 'tools/transpiler/spec/**/*', included: false},

      // Dependencies, installed with `pub install`.
      {pattern: 'packages/**/*.dart', included: false, watched: false},

      // Init and configure guiness.
      {pattern: 'test-main.dart', included: true}
    ],

    karmaDartImports: {
      guinness: 'package:guinness/guinness_html.dart'
    },

    // TODO(vojta): Remove the localhost:9877 from urls, once the proxy fix is merged:
    // https://github.com/karma-runner/karma/pull/1207
    //
    // Map packages to the correct urls where Karma serves them.
    proxies: {
      // Dependencies installed with `pub install`.
      '/packages/unittest': 'http://localhost:9877/base/packages/unittest',
      '/packages/guinness': 'http://localhost:9877/base/packages/guinness',
      '/packages/matcher': 'http://localhost:9877/base/packages/matcher',
      '/packages/stack_trace': 'http://localhost:9877/base/packages/stack_trace',
      '/packages/collection': 'http://localhost:9877/base/packages/collection',
      '/packages/path': 'http://localhost:9877/base/packages/path',

      // Local dependencies, transpiled from the source.
      '/packages/angular': 'http://localhost:9877/base/modules/angular',
      '/packages/benchpress': 'http://localhost:9877/base/modules/benchpress',
      '/packages/core': 'http://localhost:9877/base/modules/core',
      '/packages/change_detection': 'http://localhost:9877/base/modules/change_detection',
      '/packages/reflection': 'http://localhost:9877/base/modules/reflection',
      '/packages/router': 'http://localhost:9877/base/modules/router',
      '/packages/di': 'http://localhost:9877/base/modules/di',
      '/packages/directives': 'http://localhost:9877/base/modules/directives',
      '/packages/facade': 'http://localhost:9877/base/modules/facade',
      '/packages/forms': 'http://localhost:9877/base/modules/forms',
      '/packages/test_lib': 'http://localhost:9877/base/modules/test_lib',
      '/packages/mock': 'http://localhost:9877/base/modules/mock',
    },

    preprocessors: {
      'modules/**/*.js': ['ts2dart'],
      'modules/angular2/src/reflection/reflector.ts': ['ts2dart'],
      'tools/**/*.js': ['ts2dart']
    },

    ts2dartPreprocessor: {
      resolveModuleName: file2moduleName,
      transformPath: function(fileName) {
        return fileName.replace(/\.(js|ts)$/, '.dart');
      }
    },

    customLaunchers: {
      DartiumWithWebPlatform: {
        base: 'Dartium',
        flags: ['--enable-experimental-web-platform-features'] }
    },
    browsers: ['DartiumWithWebPlatform'],

    port: 9877
  });


  config.plugins.push(require('./tools/transpiler/karma-ts2dart-preprocessor'));
};
