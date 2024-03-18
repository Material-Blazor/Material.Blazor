import { MDCMenuSurface } from '@material/menu-surface';

export function show(elem, dotNetObject) {
    if (!elem) {
        return;
    }

    elem._popover = elem._popover || MDCMenuSurface.attachTo(elem);
    elem._dotNetObject = dotNetObject;

    const openedCallback = () => {
        elem._dialog.unlisten('MDCMenuSurface:opened', openedCallback);
        dotNetObject.invokeMethodAsync('NotifyOpened');
    };

    elem._popover.listen('MDCMenuSurface:opened', openedCallback);

    const closedCallback = () => {
        elem._dialog.unlisten('MDCDialog:closing', closedCallback);
        dotNetObject.invokeMethodAsync('NotifyClosed');
    };

    elem._popover.listen('MDCMenuSurface:closed', closedCallback);
    elem._popover.open();
}

export function hide(elem) {
    if (!elem) {
        return;
    }

    if (elem._popover) {
        elem._popover.close();
    }
}
