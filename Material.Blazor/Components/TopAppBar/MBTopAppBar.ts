import { MDCTopAppBar } from '@material/top-app-bar';

export function init(elem, scrollTarget) {
    elem._topAppBar = MDCTopAppBar.attachTo(elem);
    if (scrollTarget) {
        elem._topAppBar.setScrollTarget(document.querySelector(scrollTarget));
    }
}
