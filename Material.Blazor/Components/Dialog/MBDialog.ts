import { MDCDialog } from '@material/dialog';

export function show(elem, dotNetObject, escapeKeyAction, scrimClickAction): any {
    if (!elem) {
        return;
    }

    elem._dialog = elem._dialog || MDCDialog.attachTo(elem);
    elem._dotNetObject = dotNetObject;

    const openedCallback = () => {
        elem._dialog.unlisten('MDCDialog:opened', openedCallback);
        dotNetObject.invokeMethodAsync('NotifyOpened');
    };

    elem._dialog.listen('MDCDialog:opened', openedCallback);

    elem._dialog.escapeKeyAction = escapeKeyAction;
    elem._dialog.scrimClickAction = scrimClickAction;

    const closingCallback = event => {
        elem._dialog.unlisten('MDCDialog:closing', closingCallback);
        dotNetObject.invokeMethodAsync('NotifyClosed', event.detail.action);
    };

    elem._dialog.listen('MDCDialog:closing', closingCallback);
    elem._dialog.open();
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
