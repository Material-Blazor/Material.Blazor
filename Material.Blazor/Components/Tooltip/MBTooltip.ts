import { MDCTooltip } from '@material/tooltip';

export function init(arrayOfReferences) {
    arrayOfReferences
        .forEach(i => MDCTooltip.attachTo(i));
}
