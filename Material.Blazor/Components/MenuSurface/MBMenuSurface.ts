import { MDCMenuSurface } from '@material/menu-surface';

export function init(elem, dotNetObject) {
    elem._menu = MDCMenuSurface.attachTo(elem);

    const closedCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyClosed');
    };

    elem._menu.listen('MDCMenuSurface:closed', closedCallback);
}

export function show(elem) {
    if (elem._menu) {
        elem._menu.open();
    }
}

export function hide(elem) {
    if (elem._menu) {
        elem._menu.close();
    }
}
