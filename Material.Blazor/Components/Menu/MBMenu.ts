import { MDCMenu } from '@material/menu';

export function init(elem, dotNetObject) {
    elem._menu = MDCMenu.attachTo(elem);

    const closedCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyClosed');
    };

    elem._menu.listen('MDCMenuSurface:closed', closedCallback);
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
