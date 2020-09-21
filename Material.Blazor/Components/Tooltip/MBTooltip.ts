import { MDCTooltip } from '@material/tooltip';

export function init(elems) {
    elems
        .filter(f => f.__internalId !== null)
        .forEach(i => MDCTooltip.attachTo(i));
}
