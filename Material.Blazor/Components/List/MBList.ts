import { MDCList } from '@material/list';
import { MDCRipple } from '@material/ripple';

export function init(elem, keyboardInteractions, ripple) {
    if (keyboardInteractions == true) {
        const list = MDCList.attachTo(elem);

        if (ripple == true) {
            list.listElements.map((elem) => MDCRipple.attachTo(elem));
        }
    }
}
