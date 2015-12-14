var perfUtil = require('angular2/src/test_lib/perf_util');

describe('ng2 di benchmark', function () {

  var URL = 'benchmarks/src/di/di_benchmark.html';

  afterEach(perfUtil.verifyNoBrowserErrors);

  it('should log the stats for getByToken', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#getByToken'],
      id: 'ng2.di.getByToken',
      params: [{
        name: 'iterations', value: 20000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for injection (in ms)'
      }
    }).then(done, done.fail);
  });

  it('should log the stats for getByKey', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#getByKey'],
      id: 'ng2.di.getByKey',
      params: [{
        name: 'iterations', value: 20000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for injection (in ms)'
      }
    }).then(done, done.fail);
  });

  it('should log the stats for getChild', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#getChild'],
      id: 'ng2.di.getChild',
      params: [{
        name: 'iterations', value: 20000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for getChild (in ms)'
      }
    }).then(done, done.fail);
  });

  it('should log the stats for instantiate', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#instantiate'],
      id: 'ng2.di.instantiate',
      params: [{
        name: 'iterations', value: 10000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for instantiate (in ms)'
      }
    }).then(done, done.fail);
  });

  /**
   * This benchmark measures the cost of creating a new injector with a mix
   * of binding types: Type, unresolved, unflattened.
   */
  it('should log the stats for createVariety', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#createVariety'],
      id: 'ng2.di.createVariety',
      params: [{
        name: 'iterations', value: 10000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for createVariety (in ms)'
      }
    }).then(done, done.fail);
  });

  /**
   * Same as 'createVariety' benchmark but operates on fully resolved bindings.
   */
  it('should log the stats for createVarietyResolved', function(done) {
    perfUtil.runClickBenchmark({
      url: URL,
      buttons: ['#createVarietyResolved'],
      id: 'ng2.di.createVarietyResolved',
      params: [{
        name: 'iterations', value: 10000, scale: 'linear'
      }],
      microMetrics: {
        'injectAvg': 'avg time for createVarietyResolved (in ms)'
      }
    }).then(done, done.fail);
  });

});
