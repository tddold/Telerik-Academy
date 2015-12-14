library angular2.benchmark.transform.directive_linker.simple;

import 'dart:async';
import 'package:angular2/src/transform/common/options.dart';
import 'package:angular2/src/transform/directive_linker/transformer.dart';
import 'package:barback/barback.dart';
import 'package:code_transformers/benchmarks.dart';
import 'package:unittest/unittest.dart';

Future main() => runBenchmark();

allTests() {
  test('Directive Linker Benchmark Runs', runBenchmark);
}

Future runBenchmark() async {
  var files = {
    new AssetId('a', 'a.ng_deps.dart'): aContents,
    new AssetId('a', 'b.ng_deps.dart'): bContents,
    new AssetId('a', 'c.ng_deps.dart'): cContents,
  };
  var benchmark = new TransformerBenchmark([[new DirectiveLinker()]], files);
  print('\nRunning directive_linker benchmark...');
  var result = await benchmark.measure();
  print('Done, took ${result.round()}μs on average.');
}

const aContents = '''
library a.ng_deps.dart;

import 'package:angular2/src/core/application.dart';
import 'package:angular2/src/reflection/reflection_capabilities.dart';
import 'b.dart';

bool _visited = false;
void initReflector(reflector) {
  if (_visited) return;
  _visited = true;
}''';

const bContents = '''
library b.ng_deps.dart;

import 'b.dart';
import 'package:angular2/src/core/annotations/annotations.dart';

bool _visited = false;
void initReflector(reflector) {
  if (_visited) return;
  _visited = true;
  reflector
    ..registerType(DependencyComponent, {
      'factory': () => new DependencyComponent(),
      'parameters': const [],
      'annotations': const [const Component(selector: '[salad]')]
    });
}
''';

const cContents = '''
library c.ng_deps.dart;

import 'c.dart';
import 'package:angular2/src/core/annotations/annotations.dart';
import 'b.dart' as dep;

bool _visited = false;
void initReflector(reflector) {
  if (_visited) return;
  _visited = true;
  reflector
    ..registerType(MyComponent, {
      'factory': () => new MyComponent(),
      'parameters': const [],
      'annotations': const [
        const Component(
            selector: '[soup]', services: const [dep.DependencyComponent])
      ]
    });
}''';
