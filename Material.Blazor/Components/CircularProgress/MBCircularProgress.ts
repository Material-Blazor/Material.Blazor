import { MDCCircularProgress } from '@material/circular-progress';

export function init(elem, progress) {
    if (!elem) {
        return;
    }
    elem._circularProgress = MDCCircularProgress.attachTo(elem);
    setProgress(elem, progress);
}

export function setProgress(elem, progress) {
    if (!elem) {
        return;
    }
    elem._circularProgress.progress = progress;
}
