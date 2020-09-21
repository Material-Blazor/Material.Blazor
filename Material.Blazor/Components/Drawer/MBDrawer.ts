import { MDCDrawer } from '@material/drawer';

export function toggle(elem, isOpen) {
        const drawer = MDCDrawer.attachTo(elem);
        drawer.open = isOpen;
    }
