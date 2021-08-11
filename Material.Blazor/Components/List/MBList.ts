import { MDCList } from '@material/list';
import { MDCRipple } from '@material/ripple';

export function init(elem, keyboardInteractions, ripple) {
    if (!elem) {
        return;
    }
    if (keyboardInteractions == true) {
        elem._list = MDCList.attachTo(elem);

        if (ripple == true) {
            elem._list.listElements.map((elem) => MDCRipple.attachTo(elem));
        }
    }
}
