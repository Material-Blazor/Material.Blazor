import { MDCMenuSurface } from '@material/menu-surface';

export function init(elem, dotNetObject) {
    if (!elem) {
        return;
    }

    elem._menu = MDCMenuSurface.attachTo(elem);

    const openedCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyOpened');
    };

    elem._menu.listen('MDCMenuSurface:opened', openedCallback);

    const closedCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyClosed');
    };

    elem._menu.listen('MDCMenuSurface:closed', closedCallback);
}

export function show(elem) {
    if (!elem) {
        return;
    }
    if (elem._menu) {
        elem._menu.open();
    }
}

export function hide(elem) {
    if (!elem) {
        return;
    }

    if (elem._menu) {
        elem._menu.close();
    }
}
