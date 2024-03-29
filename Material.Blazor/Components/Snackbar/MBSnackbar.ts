﻿import { MDCSnackbar } from '@material/snackbar';

export function init(elem, dotnetReference, timeoutMs: number) {
    if (!elem) {
        return;
    }
    elem._snackbar = new MDCSnackbar(elem);
    elem._snackbar.listen('MDCSnackbar:closed', (r) => {
        dotnetReference.invokeMethodAsync('Closed', r);
    });
    elem._snackbar.timeoutMs = timeoutMs;
    elem._snackbar.open();
}
