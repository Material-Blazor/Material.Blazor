import { MDCDrawer } from '@material/drawer';

export function init(elem, isOpen) {
    elem._drawer = MDCDrawer.attachTo(elem);
    toggle(elem, isOpen);
}

export function destroy(elem) {
    elem._drawer.destroy();
}

export function toggle(elem, isOpen) {
    elem._drawer.open = isOpen;
}
