import { MDCRipple } from '@material/ripple';

export function init(elem): void {
    if (!elem) {
        return;
    }
    elem._ripple = MDCRipple.attachTo(elem);
}
