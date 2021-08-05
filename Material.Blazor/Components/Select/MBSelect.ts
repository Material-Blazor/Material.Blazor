import { MDCSelect } from '@material/select';

export function init(elem, dotNetObject) {
    elem._select = MDCSelect.attachTo(elem);

    elem._select.listen('MDCSelect:change', () => {
        dotNetObject.invokeMethodAsync('NotifySelected', elem._select.selectedIndex);
    });
}

export function setDisabled(elem, value) {
    elem._select.disabled = value;
}

export function setIndex(elem, index) {
    elem._select.selectedIndex = index;
}
