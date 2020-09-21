import { MDCRipple } from '@material/ripple';

export function init(elem) {
    //    elem._iconButtonToggle = mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
    elem._iconButtonToggle = MDCRipple.attachTo(elem);
}

export function setOn(elem, isOn) {
    elem._iconButtonToggle.on = isOn;
}

export function click(elem) {
    elem._iconButtonToggle.root.click();
}
