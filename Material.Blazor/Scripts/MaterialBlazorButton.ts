//import { MDCRipple } from '@material/ripple';

const MDCRipple = mdc.MDCRipple;

namespace MaterialBlazorButtonWrapper {

    export class MaterialBlazorButtonFunctions {
        public init(elem): void {
            MDCRipple.attachTo(elem);
        }
    }

    export function Load(): void {
        window['MaterialBlazorButton'] = new MaterialBlazorButtonFunctions();
    }
}

MaterialBlazorButtonWrapper.Load();