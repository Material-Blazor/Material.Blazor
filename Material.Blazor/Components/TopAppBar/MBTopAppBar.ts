import { MDCTopAppBar } from '@material/top-app-bar';

export function init(elem, scrollTarget) {
    const topAppBar = MDCTopAppBar.attachTo(elem);
    if (scrollTarget) {
        topAppBar.setScrollTarget(document.querySelector(scrollTarget));
    }
}
