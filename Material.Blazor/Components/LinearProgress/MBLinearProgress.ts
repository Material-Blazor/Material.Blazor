import { MDCLinearProgress } from '@material/linear-progress';

export function init(elem, progress, buffer) {
    if (!elem) {
        return;
    }
    elem._linearProgress = MDCLinearProgress.attachTo(elem);
    setProgress(elem, progress, buffer);
}

export function setProgress(elem, progress, buffer) {
    if (!elem) {
        return;
    }
    elem._linearProgress.progress = progress;
    elem._linearProgress.buffer = buffer;
}

export function restartAnimation(elem) {
    if (!elem) {
        return;
    }
    elem._linearProgress.foundation.restartAnimation();
}
