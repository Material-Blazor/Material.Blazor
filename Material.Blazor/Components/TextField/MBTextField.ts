import { MDCTextField, MDCTextFieldHelperText } from '@material/textfield';

export function init(elem, value, helperTextElem, helperText, helperTextPersistent, performsValidation) {
    if (!elem) {
        return;
    }

    elem._textField = MDCTextField.attachTo(elem);
    setValue(elem, value);
    setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, false, "");
}

export function setValue(elem, value) {
    if (!elem) {
        return;
    }
    
    elem._textField.value = value;
}

export function setDisabled(elem, value) {
    if (!elem) {
        return;
    }
    elem._textField.disabled = value;
}

export function setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, shakeLabel, validationMessage) {
    if (!elem || !helperTextElem) {
        return;
    }
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

export function setType(elem, value, inputElem, type, formNoValidate) {
    if (!elem || !inputElem) {
        return;
    }
    inputElem.setAttribute("type", type);
    inputElem.setAttribute("formnovalidate", formNoValidate);

    elem._textField.value = value;

    // Check focus to eliminate race condition where if you (i) select a numeric field, (ii) click a different window
    // then (iii) click back and straight into another numeric field, the two fields would conflict and flash between them.
    // Seemed to happen in Blazor Server (presumably due to slower JS Invoke timing). Also probably not needed. Time will tell.
    if (formNoValidate && elem._textField.foundation.adapter.isFocused() == true) {
        //inputElem.focus();
        inputElem.select();
    }
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

