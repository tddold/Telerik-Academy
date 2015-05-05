library angular2.test.transform.debug_reflection_remover_files;

// This file is intentionally formatted as a string to avoid having the
// automatic transformer prettify it.
//
// This file represents transformed user code. Because this code will be
// linked to output by a source map, we cannot change line numbers from the
// original code and we therefore add our generated code on the same line as
// those we are removing.

var code = """
library web_foo;

import 'package:angular2/src/core/application.dart';
import 'package:angular2/src/reflection/reflection.dart';
import 'package:angular2/src/reflection/debug_reflection_capabilities.dart';import 'index.ng_deps.dart' as ngStaticInit0;

void main() {
  reflector.reflectionCapabilities = new ReflectionCapabilities();ngStaticInit0.initReflector(reflector);
  bootstrap(MyComponent);
}
""";
