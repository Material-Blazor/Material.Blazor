﻿import { MDCTextField } from '@material/textfield';
import { MDCMenu } from '@material/menu';

export function init(textElem, menuElem, dotNetObject): any {
    if (!textElem || !menuElem) {
        return;
    }
    textElem._textField = MDCTextField.attachTo(textElem);
    menuElem._menu = MDCMenu.attachTo(menuElem);

    menuElem._menu.menuSurface.foundation.adapter.handleMenuSurfaceOpened = () => {
        menuElem._menu.foundation.setDefaultFocusState(0);
    };

    const closedCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyClosed');
    };

    menuElem._menu.listen('MDCMenuSurface:closed', closedCallback);
}

export function open(menuElem): void {
    menuElem._menu.open = true;
    menuElem._menu.foundation.setDefaultFocusState(0);
}

export function close(menuElem): void {
    menuElem._menu.open = false;
}

export function setValue(textElem, value): void {
    textElem._textField.value = value;
}

export function setDisabled(textElem, disabled): void {
    textElem._textField.disabled = disabled;
}
