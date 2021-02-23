import { MDCRipple } from '@material/ripple';

export function init(elem): void {
    elem._ripple = MDCRipple.attachTo(elem);
    elem._ripple.unbounded = true;
}

export function destroy(elem): void {
    elem?._ripple?.destroy();
}
