import { MDCTooltip } from '@material/tooltip';

export function init(arrayOfReferences) {
    arrayOfReferences.forEach(elem => elem._tooltip = MDCTooltip.attachTo(elem));
}

export function destroy(elem) {
    elem?._tooltip?.destroy();
}
