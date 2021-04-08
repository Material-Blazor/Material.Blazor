import { MDCTooltip } from '@material/tooltip';

export function init(arrayOfReferences) {
    for (const elem of arrayOfReferences) {
        try {
            MDCTooltip.attachTo(elem);
        } catch (e) {
        }
    }
}
