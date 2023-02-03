import { MDCTopAppBar } from '@material/top-app-bar';

export function init(elem, scrollTarget) {
    if (!elem) {
        return;
    }
    elem._topAppBar = MDCTopAppBar.attachTo(elem);
    if (scrollTarget) {
        elem._topAppBar.setScrollTarget(document.querySelector(scrollTarget));
    }
}
