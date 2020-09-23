import { MDCSelect } from '@material/select';

export function init(selectElem, dotNetObject) {
    selectElem._select = MDCSelect.attachTo(selectElem);

    return new Promise(() => {
        selectElem._select.foundation.handleMenuItemAction = index => {
            selectElem._select.foundation.setSelectedIndex(index);
            dotNetObject.invokeMethodAsync('NotifySelectedAsync', index);
        };
    });
}

export function setDisabled(elem, value) {
    elem._select.disabled = value;
}

export function setIndex(elem, index) {
    elem._select.selectedIndex = index;
}
