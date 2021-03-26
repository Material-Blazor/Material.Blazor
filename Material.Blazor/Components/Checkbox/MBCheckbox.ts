import { MDCCheckbox } from '@material/checkbox';
import { MDCFormField } from '@material/form-field';

export function init(elem, formFieldElem, checked, indeterminate) {
    elem._checkbox = MDCCheckbox.attachTo(elem);
    elem._checkbox.checked = checked;
    elem._checkbox.indeterminate = indeterminate;

    elem._formField = MDCFormField.attachTo(formFieldElem);
    elem._formField.input = elem._checkbox;
}

export function setChecked(elem, checked) {
    elem._checkbox.checked = checked;
}

export function setIndeterminate(elem, indeterminate) {
    if (elem?._checkbox == null) {
        return;
    }
    elem._checkbox.indeterminate = indeterminate;
}

export function setDisabled(elem, disabled) {
    elem._checkbox.disabled = disabled;
}
