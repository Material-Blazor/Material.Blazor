import { MDCLinearProgress } from '@material/linear-progress';

export function init(elem, progress, buffer) {
    elem._linearProgress = MDCLinearProgress.attachTo(elem);
    setProgress(elem, progress, buffer);
}

export function destroy(elem): void {
    elem._linearProgress.destroy();
}

export function setProgress(elem, progress, buffer) {
    elem._linearProgress.progress = progress;
    elem._linearProgress.buffer = buffer;
}
