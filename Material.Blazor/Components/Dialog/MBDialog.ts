﻿import { MDCDialog } from '@material/dialog';

export function show(elem, dotNetObject, escapeKeyAction, scrimClickAction): any {
    elem._dialog = elem._dialog || MDCDialog.attachTo(elem);
    elem._dotNetObject = dotNetObject;

    const dialog = elem._dialog;

    const openedCallback = () => {
        dialog.unlisten('MDCDialog:opened', openedCallback);
        dotNetObject.invokeMethodAsync('NotifyOpenedAsync');
    };
    dialog.listen('MDCDialog:opened', openedCallback);

    dialog.escapeKeyAction = escapeKeyAction;
    dialog.scrimClickAction = scrimClickAction;

    return new Promise(resolve => {

        const closingCallback = event => {
            dialog.unlisten('MDCDialog:closing', closingCallback);
            resolve(event.detail.action);
        };

        dialog.listen('MDCDialog:closing', closingCallback);
        dialog.open();
    });
}

export function hide(elem, dialogAction) {
    if (elem && elem._dialog) {
        elem._dialog.close(dialogAction || 'dismissed');
        elem._dialog.destroy();
    }
}
