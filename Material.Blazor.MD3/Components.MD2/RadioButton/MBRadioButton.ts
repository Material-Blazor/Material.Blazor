import { MDCFormField } from '@material/form-field';
import { MDCRadio } from '@material/radio';

export function init(elem, formFieldElem, isChecked) {
    if (!elem) {
        return;
    }
    elem._radio = MDCRadio.attachTo(elem);
    elem._radio.checked = isChecked;
    elem._formField = MDCFormField.attachTo(formFieldElem);
    elem._formField.input = elem._radio;
}

export function setDisabled(elem, value) {
    if (!elem) {
        return;
    }
    elem._radio.disabled = value;
}

export function setChecked(elem, isChecked) {
    if (!elem) {
        return;
    }
    elem._radio.checked = isChecked;
}
