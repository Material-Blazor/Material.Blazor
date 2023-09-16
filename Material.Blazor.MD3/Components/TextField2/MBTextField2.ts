 export function selectFieldContent(elem) {
    if (!elem) {
        return;
    }

    // Check focus to eliminate race condition where if you
    //  (i) select a numeric field
    //  (ii) click a different window
    //  (iii) click back and straight into another numeric field
    // The two fields would conflict and flash between them.
    // Seemed to happen in Blazor Server (presumably due to slower JS Invoke timing).
    // Also probably not needed.Time will tell.

    if (elem.focused == true) {
        elem.select();
    }
}
