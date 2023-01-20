export function selectFieldContent(elem) {
    if (!elem) {
        return;
    }

    elem.select();

    // Check focus to eliminate race condition where if you (i) select a numeric field, (ii) click a different window
    // then (iii) click back and straight into another numeric field, the two fields would conflict and flash between them.
    // Seemed to happen in Blazor Server (presumably due to slower JS Invoke timing). Also probably not needed. Time will tell.
    //if (elem._textField.foundation.adapter.isFocused() == true) {
    //    //inputElem.focus();
    //    inputElem.select();
    //}
}
