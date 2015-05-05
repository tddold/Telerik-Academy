import {DOM} from 'angular2/src/dom/dom_adapter';
import {BrowserDomAdapter} from 'angular2/src/dom/browser_adapter';
import {Type} from 'angular2/src/facade/lang';
import {document} from 'angular2/src/facade/browser';
import {NativeShadowDomStrategy} from 'angular2/src/render/dom/shadow_dom/native_shadow_dom_strategy';

import {Parser, Lexer, DynamicChangeDetection} from 'angular2/change_detection';

import {Compiler, CompilerCache} from 'angular2/src/core/compiler/compiler';
import {DirectiveMetadataReader} from 'angular2/src/core/compiler/directive_metadata_reader';

import {Component} from 'angular2/src/core/annotations_impl/annotations';
import {Directive} from 'angular2/src/core/annotations_impl/annotations';
import {View} from 'angular2/src/core/annotations_impl/view';
import {TemplateLoader} from 'angular2/src/render/dom/compiler/template_loader';
import {TemplateResolver} from 'angular2/src/core/compiler/template_resolver';
import {UrlResolver} from 'angular2/src/services/url_resolver';
import {StyleUrlResolver} from 'angular2/src/render/dom/shadow_dom/style_url_resolver';
import {ComponentUrlMapper} from 'angular2/src/core/compiler/component_url_mapper';

import {reflector} from 'angular2/src/reflection/reflection';
import {ReflectionCapabilities} from 'angular2/src/reflection/reflection_capabilities';
import {getIntParameter, bindAction} from 'angular2/src/test_lib/benchmark_util';

import {ProtoViewFactory} from 'angular2/src/core/compiler/proto_view_factory';
import {DirectDomRenderer} from 'angular2/src/render/dom/direct_dom_renderer';
import * as rc from 'angular2/src/render/dom/compiler/compiler';

function setupReflector() {
  reflector.reflectionCapabilities = new ReflectionCapabilities();

  reflector.registerGetters({
    "inter0": (a) => a.inter0, "inter1": (a) => a.inter1,
    "inter2": (a) => a.inter2, "inter3": (a) => a.inter3, "inter4": (a) => a.inter4,

    "value0": (a) => a.value0, "value1": (a) => a.value1,
    "value2": (a) => a.value2, "value3": (a) => a.value3, "value4": (a) => a.value4,

    "prop" : (a) => a.prop
  });

  reflector.registerSetters({
    "inter0": (a,v) => a.inter0 = v, "inter1": (a,v) => a.inter1 = v,
    "inter2": (a,v) => a.inter2 = v, "inter3": (a,v) => a.inter3 = v, "inter4": (a,v) => a.inter4 = v,

    "value0": (a,v) => a.value0 = v, "value1": (a,v) => a.value1 = v,
    "value2": (a,v) => a.value2 = v, "value3": (a,v) => a.value3 = v, "value4": (a,v) => a.value4 = v,

    "attr0": (a,v) => a.attr0 = v, "attr1": (a,v) => a.attr1 = v,
    "attr2": (a,v) => a.attr2 = v, "attr3": (a,v) => a.attr3 = v, "attr4": (a,v) => a.attr4 = v,

    "prop": (a,v) => a.prop = v
  });
}

export function main() {
  BrowserDomAdapter.makeCurrent();
  var count = getIntParameter('elements');

  setupReflector();
  var reader = new DirectiveMetadataReader();
  var cache = new CompilerCache();
  var templateResolver = new FakeTemplateResolver();
  var urlResolver = new UrlResolver();
  var styleUrlResolver = new StyleUrlResolver(urlResolver);
  var shadowDomStrategy = new NativeShadowDomStrategy(styleUrlResolver);
  var renderer = new DirectDomRenderer(
    new rc.DefaultCompiler(
      new Parser(new Lexer()), shadowDomStrategy, new TemplateLoader(null, urlResolver)
    ),
    null,
    null,
    shadowDomStrategy
  );
  var compiler = new Compiler(
    reader,
    cache,
    templateResolver,
    new ComponentUrlMapper(),
    urlResolver,
    renderer,
    new ProtoViewFactory(new DynamicChangeDetection(null))
  );
  var templateNoBindings = createTemplateHtml('templateNoBindings', count);
  var templateWithBindings = createTemplateHtml('templateWithBindings', count);

  function compileNoBindings() {
    templateResolver.setTemplateHtml(templateNoBindings);
    cache.clear();
    compiler.compile(BenchmarkComponent);
  }

  function compileWithBindings() {
    templateResolver.setTemplateHtml(templateWithBindings);
    cache.clear();
    compiler.compile(BenchmarkComponent);
  }

  bindAction('#compileNoBindings', compileNoBindings);
  bindAction('#compileWithBindings', compileWithBindings);
}

function createTemplateHtml(templateId, repeatCount) {
  var template = DOM.querySelectorAll(document, `#${templateId}`)[0];
  var content = DOM.getInnerHTML(template);
  var result = '';
  for (var i=0; i<repeatCount; i++) {
    result += content;
  }
  return result;
}

@Directive({
  selector: '[dir0]',
  properties: {
    'prop': 'attr0'
  }
})
class Dir0 {}

@Directive({
  selector: '[dir1]',
  properties: {
    'prop': 'attr1'
  }
})
class Dir1 {
  constructor(dir0:Dir0) {}
}

@Directive({
  selector: '[dir2]',
  properties: {
    'prop': 'attr2'
  }
})
class Dir2 {
  constructor(dir1:Dir1) {}
}

@Directive({
  selector: '[dir3]',
  properties: {
    'prop': 'attr3'
  }
})
class Dir3 {
  constructor(dir2:Dir2) {}
}

@Directive({
  selector: '[dir4]',
  properties: {
    'prop': 'attr4'
  }
})
class Dir4 {
  constructor(dir3:Dir3) {}
}

@Component()
class BenchmarkComponent {}

class FakeTemplateResolver extends TemplateResolver {
  _template: View;

  constructor() {
    super();
  }

  setTemplateHtml(html: string) {
    this._template = new View({
      template: html,
      directives: [Dir0, Dir1, Dir2, Dir3, Dir4]
    });
  }

  resolve(component: Type): View {
    return this._template;
  }
}
