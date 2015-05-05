library angular2.benchmark.transform.template_compiler.url;

import 'dart:async';
import 'package:angular2/src/transform/common/options.dart';
import 'package:angular2/src/transform/template_compiler/transformer.dart';
import 'package:barback/barback.dart';
import 'package:code_transformers/benchmarks.dart';
import 'package:unittest/unittest.dart';

Future main() => runBenchmark();

allTests() {
  test('Url Template Compiler Benchmark Runs', runBenchmark);
}

Future runBenchmark() async {
  var options = new TransformerOptions(['index.dart']);
  var files = {
    new AssetId('a', 'web/a.ng_deps.dart'): aContents,
    new AssetId('a', 'web/template.html'): templateContents,
  };
  var benchmark =
      new TransformerBenchmark([[new TemplateCompiler(options)]], files);
  print('\nRunning template_compiler url benchmark...');
  var result = await benchmark.measure();
  print('Done, took ${result.round()}μs on average.');
}

const aContents = '''
library examples.src.hello_world.index_common_dart;

import 'hello.dart';
import 'package:angular2/angular2.dart'
    show bootstrap, Component, Decorator, Template, NgElement;

bool _visited = false;
void initReflector(reflector) {
  if (_visited) return;
  _visited = true;
  reflector
    ..registerType(HelloCmp, {
      'factory': () => new HelloCmp(),
      'parameters': const [const []],
      'annotations': const [
        const Component(selector: 'hello-app'),
        const Template(url: 'template.html')
      ]
    });
}
''';

const templateContents = '''
<button (click)="action()">go</button>
{{greeting}}
''';
