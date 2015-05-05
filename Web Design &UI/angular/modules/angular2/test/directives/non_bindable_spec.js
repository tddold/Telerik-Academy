import {
  AsyncTestCompleter,
  beforeEach,
  ddescribe,
  describe,
  el,
  expect,
  iit,
  inject,
  it,
  xit,
} from 'angular2/test_lib';
import {DOM} from 'angular2/src/dom/dom_adapter';

import {Directive, Component} from 'angular2/src/core/annotations_impl/annotations';
import {View} from 'angular2/src/core/annotations_impl/view';

import {ElementRef} from 'angular2/src/core/compiler/element_ref';

import {NonBindable} from 'angular2/src/directives/non_bindable';

import {TestBed} from 'angular2/src/test_lib/test_bed';

export function main() {
  describe('non-bindable', () => {
    it('should not interpolate children', inject([TestBed, AsyncTestCompleter], (tb, async) => {
      var template = '<div>{{text}}<span non-bindable>{{text}}</span></div>';
      tb.createView(TestComponent, {html: template}).then((view) => {
        view.detectChanges();
        expect(DOM.getText(view.rootNodes[0])).toEqual('foo{{text}}');
        async.done();
      });
    }));

    it('should ignore directives on child nodes', inject([TestBed, AsyncTestCompleter], (tb, async) => {
      var template = '<div non-bindable><span id=child test-dec>{{text}}</span></div>';
      tb.createView(TestComponent, {html: template}).then((view) => {
        view.detectChanges();
        var span = DOM.querySelector(view.rootNodes[0], '#child');
        expect(DOM.hasClass(span, 'compiled')).toBeFalsy();
        async.done();
      });
    }));

    it('should trigger directives on the same node', inject([TestBed, AsyncTestCompleter], (tb, async) => {
      var template = '<div><span id=child non-bindable test-dec>{{text}}</span></div>';
      tb.createView(TestComponent, {html: template}).then((view) => {
        view.detectChanges();
        var span = DOM.querySelector(view.rootNodes[0], '#child');
        expect(DOM.hasClass(span, 'compiled')).toBeTruthy();
        async.done();
      });
    }));
  })
}

@Component({selector: 'test-cmp'})
@View({directives: [NonBindable, TestDirective]})
class TestComponent {
  text: string;
  constructor() {
    this.text = 'foo';
  }
}

@Directive({
  selector: '[test-dec]'
})
class TestDirective {
  constructor(el: ElementRef) {
    DOM.addClass(el.domElement, 'compiled');
  }
}
