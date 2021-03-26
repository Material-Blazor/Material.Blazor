import { MDCFormField } from '@material/form-field';
import { MDCRadio } from '@material/radio';

export function init(elem, formFieldElem, isChecked) {
    elem._radio = MDCRadio.attachTo(elem);
    elem._radio.checked = isChecked;
    elem._formField = MDCFormField.attachTo(formFieldElem);
    elem._formField.input = elem._radio;
}

export function setDisabled(elem, value) {
    elem._radio.disabled = value;
}

export function setChecked(elem, isChecked) {
    elem._radio.checked = isChecked;
}
