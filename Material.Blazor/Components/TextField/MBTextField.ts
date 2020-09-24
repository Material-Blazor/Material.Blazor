import { MDCTextField, MDCTextFieldHelperText } from '@material/textfield';

export function init(elem, helperTextElem, helperText, helperTextPersistent, performsValidation) {
    elem._textField = MDCTextField.attachTo(elem);
    setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, false, "");
}

export function select(inputElem) {
    inputElem.focus();
    inputElem.select();
}

export function setValue(elem, value) {
    elem._textField.value = value;
}

export function setDisabled(elem, value) {
    elem._textField.disabled = value;
}

export function setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, shakeLabel, validationMessage) {
    if (helperText !== "" || performsValidation === true) {
        if (!elem._helperText) {
            elem._helperText = MDCTextFieldHelperText.attachTo(helperTextElem);
        }

        if (validationMessage !== "") {
            elem._helperText.root.innerHTML = sanitizeHTMLWithBreaks(validationMessage);
            elem._helperText.foundation.setPersistent(true);
            elem._helperText.foundation.setValidation(true);
            elem._helperText.foundation.setValidity(false);
            elem._textField.foundation.setValid(false);

            if (shakeLabel) {
                elem._textField.foundation.adapter.shakeLabel(true);
            }
        }
        else if (helperText !== "") {
            elem._helperText.foundation.setContent(helperText);
            elem._helperText.foundation.setPersistent(helperTextPersistent);
            elem._helperText.foundation.setValidation(false);
            elem._helperText.foundation.setValidity(true);
            elem._textField.foundation.setValid(true);
        }
        else {
            elem._helperText.foundation.setContent("");
            elem._helperText.foundation.setPersistent(false);
            elem._helperText.foundation.setValidation(false);
            elem._helperText.foundation.setValidity(true);
            elem._textField.foundation.setValid(true);
        }
    }
}

export function setType(inputElem, value) {
    inputElem.setAttribute("type", value);
}
/*!
 * Sanitize and encode all HTML in a user-submitted string
 * (c) 2018 Chris Ferdinandi, MIT License, https://gomakethings.com
 * @param  {String} str  The user-submitted string
 * @return {String} str  The sanitized string
 */
function sanitizeHTMLWithBreaks(str) {
    let tempDiv = document.createElement('div');
    tempDiv.textContent = str;
    let sanitized = tempDiv.innerHTML;
    tempDiv.remove();
    return sanitized.replace(new RegExp(escapeRegExp("&lt;br /&gt;"), 'g'), "<br />");

    // original code in JS
//    return sanitized.replaceAll("&lt;br /&gt;", "<br />");
// https://stackoverflow.com/questions/43504533/typescript-javascript-replace-all-string-occurrences-with-random-number
}

function escapeRegExp(str) {
    return str.replace(/([.*+?^=!:${}()|\[\]\/\\])/g, "\\$1");
}

