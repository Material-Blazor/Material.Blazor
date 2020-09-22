import { MDCRipple } from '@material/ripple';
import { MDCIconButtonToggle } from '@material/icon-button';

export function init(elem) {
    elem._iconButtonToggle = MDCIconButtonToggle.attachTo(elem);
}

export function setOn(elem, isOn) {
    elem._iconButtonToggle.on = isOn;
}

export function click(elem) {
    elem._iconButtonToggle.root.click();
}
