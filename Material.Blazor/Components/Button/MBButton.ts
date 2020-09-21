import { MDCRipple } from '@material/ripple';

export class MaterialBlazorButtonFunctions {
    public init(elem): void {
        MDCRipple.attachTo(elem);
    }
}

export function Load(): void {
    window['MaterialBlazorButton'] = new MaterialBlazorButtonFunctions();
}
