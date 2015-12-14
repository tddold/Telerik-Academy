library dinner.tortilla_soup.ng_deps.dart;

import 'tortilla_soup.dart';
import 'package:angular2/di.dart' show Injectable;
import 'package:angular2/src/facade/lang.dart' show CONST;

var _visited = false;
void initReflector(reflector) {
  if (_visited) return;
  _visited = true;
  reflector
    ..registerType(TortillaSoup, {
      'factory': () => new TortillaSoup(),
      'parameters': const [],
      'annotations': const [const Soup()]
    });
}
