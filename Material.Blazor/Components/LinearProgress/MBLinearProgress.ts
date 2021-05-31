import { MDCLinearProgress } from '@material/linear-progress';

export function init(elem, progress, buffer) {
    elem._linearProgress = MDCLinearProgress.attachTo(elem);
    setProgress(elem, progress, buffer);
}

export function setProgress(elem, progress, buffer) {
    elem._linearProgress.progress = progress;
    elem._linearProgress.buffer = buffer;
}

export function restartAnimation(elem) {
    elem._linearProgress.foundation.restartAnimation();
}
