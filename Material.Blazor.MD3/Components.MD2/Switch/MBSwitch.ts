import { MDCSwitch } from '@material/switch';

export function init(elem, selected) {
    if (!elem) {
        return;
    }
    elem._switch = MDCSwitch.attachTo(elem);
    elem._switch.selected = selected;
}

export function setSelected(elem, selected) {
    if (!elem) {
        return;
    }
    elem._switch.selected = selected;
}

export function setDisabled(elem, disabled) {
    if (!elem) {
        return;
    }
    elem._switch.disabled = disabled;
}
