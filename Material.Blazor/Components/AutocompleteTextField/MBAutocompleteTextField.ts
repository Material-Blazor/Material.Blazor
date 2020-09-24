import { MDCTextField } from '@material/textfield';
import { MDCMenu } from '@material/menu';

export function init(textElem, menuElem, dotNetObject): any {
    textElem._textField = MDCTextField.attachTo(textElem);
    menuElem._menu = MDCMenu.attachTo(menuElem);
    //menuElem._menuSurface = mdc.menuSurface.MDCMenuSurface.attachTo(menuElem);

    return new Promise(() => {
        menuElem._menu.foundation.handleItemAction = listItem => {
            menuElem._menu.open = false;
            dotNetObject.invokeMethodAsync('NotifySelectedAsync', listItem.innerText);
        };

        menuElem._menu.foundation.adapter.handleMenuSurfaceOpened = () => {
            menuElem._menu.foundation.setDefaultFocusState(0);
        };

        const closedCallback = () => {
            dotNetObject.invokeMethodAsync('NotifyClosedAsync');
        };
        
        menuElem._menu.listen('MDCMenuSurface:closed', closedCallback);
    });
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
