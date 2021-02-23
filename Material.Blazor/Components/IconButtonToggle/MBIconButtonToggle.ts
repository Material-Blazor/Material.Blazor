import { MDCIconButtonToggle } from '@material/icon-button';

export function init(elem) {
    elem._iconButtonToggle = MDCIconButtonToggle.attachTo(elem);
}

export function destroy(elem): void {
    elem._iconButtonToggle.destroy();
}

export function setOn(elem, isOn) {
    elem._iconButtonToggle.on = isOn;
}

export function click(elem) {
    elem._iconButtonToggle.root.click();
}
