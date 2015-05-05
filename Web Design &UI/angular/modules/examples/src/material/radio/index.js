import {bootstrap} from 'angular2/angular2';
import {MdRadioButton, MdRadioGroup} from 'angular2_material/src/components/radio/radio_button'
import {MdRadioDispatcher} from 'angular2_material/src/components/radio/radio_dispatcher'
import {UrlResolver} from 'angular2/src/services/url_resolver';
import {commonDemoSetup, DemoUrlResolver} from '../demo_common';
import {bind} from 'angular2/di';

// TODO(radokirov): Once the application is transpiled by TS instead of Traceur,
// add those imports back into 'angular2/angular2';
import {Component, Directive} from 'angular2/src/core/annotations_impl/annotations';
import {View} from 'angular2/src/core/annotations_impl/view';

@Component({
  selector: 'demo-app',
  injectables: [MdRadioDispatcher]
})
@View({
  templateUrl: './demo_app.html',
  directives: [MdRadioGroup, MdRadioButton]
})
class DemoApp {
  thirdValue;
  groupValueChangeCount;
  individualValueChanges;
  pokemon;
  someTabindex;

  constructor() {
    this.thirdValue = 'dr-who';
    this.groupValueChangeCount = 0;
    this.individualValueChanges = 0;
    this.pokemon = '';
    this.someTabindex = 888;
  }

  chooseCharmander() {
    this.pokemon = 'fire';
  }

  onGroupChange() {
    this.groupValueChangeCount++;
  }

  onIndividualClick() {
    this.individualValueChanges++;
  }
}

export function main() {
  commonDemoSetup();
  bootstrap(DemoApp, [
    bind(UrlResolver).toValue(new DemoUrlResolver())
  ]);
}
