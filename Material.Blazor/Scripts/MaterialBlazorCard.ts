import { MDCRipple } from '@material/ripple';

namespace MaterialBlazorCardWrapper {

    export class MaterialBlazorCardFunctions {
        public init(elem): void {
            MDCRipple.attachTo(elem);
        }
    }

    export function Load(): void {
        window['MaterialBlazorCard'] = new MaterialBlazorCardFunctions();
    }
}

MaterialBlazorCardWrapper.Load();