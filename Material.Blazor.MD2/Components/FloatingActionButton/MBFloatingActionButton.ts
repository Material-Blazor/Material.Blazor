import { MDCRipple } from '@material/ripple';

export function init(elem, exited) {
    elem._fab = MDCRipple.attachTo(elem);
    elem._exited = false;
    setExited(elem, exited);
}

export function setExited(elem, exited) {
    if (elem) {
        if (exited != elem._exited) {
            elem.classList.add("mdc-fab--exited");
        }
        else {
            elem.classList.remove("mdc-fab--exited");
        }
    }
}
