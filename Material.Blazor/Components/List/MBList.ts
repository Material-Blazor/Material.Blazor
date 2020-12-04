import { MDCList } from '@material/list';
import { MDCRipple } from '@material/ripple';

export function init(elem, keyboardInteractions, ripple) {
    if (keyboardInteractions == true) {
        elem._list = MDCList.attachTo(elem);

        if (ripple == true) {
            elem._list.listElements.map((elem) => MDCRipple.attachTo(elem));
        }
    }
}

export function destroy(elem) {
    elem._list.destroy();
}
