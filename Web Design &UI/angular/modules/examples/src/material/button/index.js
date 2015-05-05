import {bootstrap, MapWrapper, ListWrapper, For} from 'angular2/angular2';
import {MdButton, MdAnchor} from 'angular2_material/src/components/button/button'
import {UrlResolver} from 'angular2/src/services/url_resolver';
import {commonDemoSetup, DemoUrlResolver} from '../demo_common';
import {bind} from 'angular2/di';

// TODO(radokirov): Once the application is transpiled by TS instead of Traceur,
// add those imports back into 'angular2/angular2';
import {Component, Directive} from 'angular2/src/core/annotations_impl/annotations';
import {View} from 'angular2/src/core/annotations_impl/view';

@Component({
  selector: 'demo-app'
})
@View({
  templateUrl: './demo_app.html',
  directives: [MdButton, MdAnchor, For]
})
class DemoApp {
  previousClick: string;
  action: string;
  clickCount: number;
  items: List<number>;

  constructor() {
    this.previousClick = 'Nothing';
    this.action = "ACTIVATE";
    this.clickCount = 0;
    this.items = [1,2,3,4,5,6,7,8,9,0];
  }

  click(msg: string) {
    this.previousClick = msg;
  }

  submit(msg: string, event) {
    event.preventDefault();
    this.previousClick = msg;
  }

  increment() {
    this.clickCount++;
  }
}

export function main() {
  commonDemoSetup();
  bootstrap(DemoApp, [
    bind(UrlResolver).toValue(new DemoUrlResolver())
  ]);
}
