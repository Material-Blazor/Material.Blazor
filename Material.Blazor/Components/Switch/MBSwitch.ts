import { MDCSwitch } from '@material/switch';

export function init(elem, checked) {
    elem._switch = MDCSwitch.attachTo(elem);
    elem._switch.checked = checked;
}

export function setChecked(elem, checked) {
    elem._switch.checked = checked;
}

export function setDisabled(elem, disabled) {
    elem._switch.disabled = disabled;
}
