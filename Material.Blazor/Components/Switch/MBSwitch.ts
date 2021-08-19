import { MDCSwitch } from '@material/switch';

export function init(elem, checked) {
    if (!elem) {
        return;
    }
    elem._switch = MDCSwitch.attachTo(elem);
    elem._switch.checked = checked;
}

export function setChecked(elem, checked) {
    if (!elem) {
        return;
    }
    elem._switch.checked = checked;
}

export function setDisabled(elem, disabled) {
    if (!elem) {
        return;
    }
    elem._switch.disabled = disabled;
}
