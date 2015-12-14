library angular2.benchmark.transform.reflection_remover.simple;

import 'dart:async';
import 'package:angular2/src/transform/common/options.dart';
import 'package:angular2/src/transform/reflection_remover/transformer.dart';
import 'package:barback/barback.dart';
import 'package:code_transformers/benchmarks.dart';
import 'package:unittest/unittest.dart';

Future main() => runBenchmark();

allTests() {
  test('Reflection Remover Benchmark Runs', runBenchmark);
}

Future runBenchmark() async {
  var options = new TransformerOptions(['web/index.dart']);
  var files = {new AssetId('a', 'web/index.dart'): indexContents,};
  var benchmark =
      new TransformerBenchmark([[new ReflectionRemover(options)]], files);
  print('\nRunning reflection_remover benchmark...');
  var result = await benchmark.measure();
  print('Done, took ${result.round()}μs on average.');
}

const indexContents = '''
library web_foo;

import 'package:angular2/src/core/application.dart';
import 'package:angular2/src/reflection/reflection.dart';
import 'package:angular2/src/reflection/reflection_capabilities.dart';

void main() {
  reflector.reflectionCapabilities = new ReflectionCapabilities();
  bootstrap(MyComponent);
}''';
