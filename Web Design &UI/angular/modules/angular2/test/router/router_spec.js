import {
  AsyncTestCompleter,
  describe,
  proxy,
  it, iit,
  ddescribe, expect,
  inject, beforeEach, beforeEachBindings,
  SpyObject} from 'angular2/test_lib';
import {IMPLEMENTS} from 'angular2/src/facade/lang';

import {Promise, PromiseWrapper} from 'angular2/src/facade/async';
import {Router, RootRouter} from 'angular2/src/router/router';
import {Pipeline} from 'angular2/src/router/pipeline';
import {RouterOutlet} from 'angular2/src/router/router_outlet';
import {SpyLocation} from 'angular2/src/mock/location_mock'
import {Location} from 'angular2/src/router/location';

import {RouteRegistry} from 'angular2/src/router/route_registry';
import {DirectiveMetadataReader} from 'angular2/src/core/compiler/directive_metadata_reader';

import {bind} from 'angular2/di';

export function main() {
  describe('Router', () => {
    var router,
        location;

    beforeEachBindings(() => [
      Pipeline,
      RouteRegistry,
      DirectiveMetadataReader,
      bind(Location).toClass(SpyLocation),
      bind(Router).toFactory((registry, pipeline, location) => {
        return new RootRouter(registry, pipeline, location, AppCmp);
      }, [RouteRegistry, Pipeline, Location])
    ]);


    beforeEach(inject([Router, Location], (rtr, loc) => {
      router = rtr;
      location = loc;
    }));


    it('should navigate based on the initial URL state', inject([AsyncTestCompleter], (async) => {
      var outlet = makeDummyRef();

      router.config({'path': '/', 'component': 'Index' })
        .then((_) => router.registerOutlet(outlet))
        .then((_) => {
          expect(outlet.spy('activate')).toHaveBeenCalled();
          expect(location.urlChanges).toEqual([]);
          async.done();
        });
    }));


    it('should activate viewports and update URL on navigate', inject([AsyncTestCompleter], (async) => {
      var outlet = makeDummyRef();

      router.registerOutlet(outlet)
        .then((_) => {
          return router.config({'path': '/a', 'component': 'A' });
        })
        .then((_) => router.navigate('/a'))
        .then((_) => {
          expect(outlet.spy('activate')).toHaveBeenCalled();
          expect(location.urlChanges).toEqual(['/a']);
          async.done();
        });
    }));

    it('should navigate after being configured', inject([AsyncTestCompleter], (async) => {
      var outlet = makeDummyRef();

      router.registerOutlet(outlet)
        .then((_) => router.navigate('/a'))
        .then((_) => {
          expect(outlet.spy('activate')).not.toHaveBeenCalled();
          return router.config({'path': '/a', 'component': 'A' });
        })
        .then((_) => {
          expect(outlet.spy('activate')).toHaveBeenCalled();
          async.done();
        });
    }));
  });
}

@proxy
@IMPLEMENTS(RouterOutlet)
class DummyOutletRef extends SpyObject {noSuchMethod(m){return super.noSuchMethod(m)}}

function makeDummyRef() {
  var ref = new DummyOutletRef();
  ref.spy('activate').andCallFake((_) => PromiseWrapper.resolve(true));
  ref.spy('canActivate').andCallFake((_) => PromiseWrapper.resolve(true));
  ref.spy('canDeactivate').andCallFake((_) => PromiseWrapper.resolve(true));
  ref.spy('deactivate').andCallFake((_) => PromiseWrapper.resolve(true));
  return ref;
}

class AppCmp {}
