import { MDCMenu } from '@material/menu';

export function init(elem, dotNetObject) {
    elem._menu = MDCMenu.attachTo(elem);

    return new Promise(() => {
        elem._menu.foundation.handleItemAction = () => {
            elem._menu.open = false;
            dotNetObject.invokeMethodAsync('NotifyClosedAsync');
        };
    });
}

export function destroy(elem) {
    elem._menu.destroy();
}

export function show(elem) {
    if (elem._menu) {
        elem._menu.open = true;
    }
}

export function hide(elem) {
    if (elem._menu) {
        elem._menu.open = false;
    }
}
