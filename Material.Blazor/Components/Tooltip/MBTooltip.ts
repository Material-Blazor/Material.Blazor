import { MDCTooltip } from '@material/tooltip';

export function init(arrayOfReferences) {
    arrayOfReferences
        .filter(f => f.__internalId !== null)  // Is this needed?
        .forEach(i => MDCTooltip.attachTo(i));
}
