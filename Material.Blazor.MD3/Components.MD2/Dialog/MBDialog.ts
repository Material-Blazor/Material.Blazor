import { MDCDialog } from '@material/dialog';

export function show(elem, dotNetObject, escapeKeyAction, scrimClickAction): any {
    if (!elem) {
        return;
    }
    elem._dialog = elem._dialog || MDCDialog.attachTo(elem);
    elem._dotNetObject = dotNetObject;

    const dialog = elem._dialog;

    const openedCallback = () => {
        dialog.unlisten('MDCDialog:opened', openedCallback);
        dotNetObject.invokeMethodAsync('NotifyOpened');
    };
    dialog.listen('MDCDialog:opened', openedCallback);

    dialog.escapeKeyAction = escapeKeyAction;
    dialog.scrimClickAction = scrimClickAction;

    const closingCallback = event => {
        dialog.unlisten('MDCDialog:closing', closingCallback);
        dotNetObject.invokeMethodAsync('NotifyClosed', event.detail.action);
    };

    dialog.listen('MDCDialog:closing', closingCallback);
    dialog.open();
}

export function hide(elem, dialogAction) {
    if (!elem) {
        return;
    }
    if (elem && elem._dialog) {
        elem._dialog.close(dialogAction || 'dismissed');
        elem._dialog.destroy();
    }
}
