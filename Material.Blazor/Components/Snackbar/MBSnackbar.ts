import { MDCSnackbar } from '@material/snackbar';

export function init(elem, dotnetReference) {
    elem._snackbar = new MDCSnackbar(elem);
    elem._snackbar.listen('MDCSnackbar:closed', (r) => {
        dotnetReference.invokeMethodAsync('Closed', r);
    });
}

export function destroy(elem) {
    elem._snackbar.destroy();
}

export function open(elem, timeoutMs: number) {
    elem._snackbar.timeoutMs = timeoutMs;
    elem._snackbar.open();
}
