import { MDCDialog } from '@material/dialog';

export function show(elem, dotNetObject, escapeKeyAction, scrimClickAction): any {
    elem._dialog = elem._dialog || MDCDialog.attachTo(elem);
    elem._dotNetObject = dotNetObject;

    return new Promise(resolve => {
        const dialog = elem._dialog;

        const openedCallback = event => {
            dialog.unlisten('MDCDialog:opened', openedCallback);
            dotNetObject.invokeMethodAsync('NotifyOpenedAsync');
        };

        const closingCallback = event => {
            dialog.unlisten('MDCDialog:closing', closingCallback);
            resolve(event.detail.action);
        };

        dialog.listen('MDCDialog:opened', openedCallback);
        dialog.listen('MDCDialog:closing', closingCallback);
        dialog.escapeKeyAction = escapeKeyAction;
        dialog.scrimClickAction = scrimClickAction;
        dialog.open();
    });
}

export function hide(elem, dialogAction) {
    if (elem && elem._dialog) {
        elem._dialog.close(dialogAction || 'dismissed');
        elem._dialog.destroy();
    }
}
