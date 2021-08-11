import { MDCDrawer } from '@material/drawer';

export function init(elem, isOpen) {
    if (!elem) {
        return;
    }
    elem._drawer = MDCDrawer.attachTo(elem);
    toggle(elem, isOpen);
}

export function toggle(elem, isOpen) {
    if (!elem) {
        return;
    }
    elem._drawer.open = isOpen;
}
