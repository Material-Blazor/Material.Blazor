import { MDCCheckbox } from '@material/checkbox';
import { MDCFormField } from '@material/form-field';

export function init(elem, formFieldElem, checked, indeterminate) {
    if (!elem || !formFieldElem) {
        return;
    }
    elem._checkbox = MDCCheckbox.attachTo(elem);
    elem._checkbox.checked = checked;
    elem._checkbox.indeterminate = indeterminate;

    elem._formField = MDCFormField.attachTo(formFieldElem);
    elem._formField.input = elem._checkbox;
}

export function setChecked(elem, checked) {
    if (!elem) {
        return;
    }
    elem._checkbox.checked = checked;
}

export function setIndeterminate(elem, indeterminate) {
    if (!elem) {
        return;
    }
    if (elem?._checkbox == null) {
        return;
    }
    elem._checkbox.indeterminate = indeterminate;
}

export function setDisabled(elem, disabled) {
    if (!elem) {
        return;
    }
    elem._checkbox.disabled = disabled;
}
