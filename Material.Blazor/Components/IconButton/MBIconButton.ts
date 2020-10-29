import { MDCRipple } from '@material/ripple';

export function init(elem) {
    const iconButtonRipple = MDCRipple.attachTo(elem);
    iconButtonRipple.unbounded = true;
}
