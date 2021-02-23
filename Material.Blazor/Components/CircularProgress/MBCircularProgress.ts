import { MDCCircularProgress } from '@material/circular-progress';

export function init(elem, progress) {
    elem._circularProgress = MDCCircularProgress.attachTo(elem);
    setProgress(elem, progress);
}

export function destroy(elem) {
    elem?._circularProgress?.destroy();
}

export function setProgress(elem, progress) {
    elem._circularProgress.progress = progress;
}
