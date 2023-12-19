export function selectFieldContent(textfieldID) {
    const textfieldElement: any | null = document.getElementById(textfieldID);

    if (!textfieldElement) {
        return;
    }

    // Check focus to eliminate race condition where if you
    //  (i) select a numeric field
    //  (ii) click a different window
    //  (iii) click back and straight into another numeric field
    // The two fields would conflict and flash between them.
    // Seemed to happen in Blazor Server (presumably due to slower JS Invoke timing).
    // Also probably not needed.Time will tell.

    if (textfieldElement.focused == true) {
        textfieldElement.select();
    }
}

export function setFieldType(textfieldID, textFieldType, formNoValidate) {
    const textfieldElement: any | null = document.getElementById(textfieldID);

    if (!textfieldElement) {
        return;
    }

    textfieldElement.setAttribute("type", textFieldType);
    textfieldElement.setAttribute("formnovalidate", formNoValidate);
}
