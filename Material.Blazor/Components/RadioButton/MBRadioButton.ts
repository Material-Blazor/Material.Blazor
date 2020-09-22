import { MDCFormField } from '@material/form-field';
import { MDCRadio } from '@material/radio';

export function init(elem, formFieldElem, isChecked) {
    elem._radio = MDCRadio.attachTo(elem);
    elem._radio.checked = isChecked;
    let formField = MDCFormField.attachTo(formFieldElem);
    formField.input = elem._radio;
}

export function setChecked(elem, isChecked) {
    elem._radio.checked = isChecked;
}
