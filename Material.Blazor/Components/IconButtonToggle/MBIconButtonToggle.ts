import { MDCIconButtonToggle } from '@material/icon-button';

export function init(elem) {
    if (!elem) {
        return;
    }
    elem._iconButtonToggle = MDCIconButtonToggle.attachTo(elem);
}

export function setOn(elem, isOn) {
    if (!elem) {
        return;
    }
    elem._iconButtonToggle.on = isOn;
}

export function click(elem) {
    if (!elem) {
        return;
    }
    elem._iconButtonToggle.root.click();
}
