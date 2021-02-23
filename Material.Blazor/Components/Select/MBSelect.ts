import { MDCSelect } from '@material/select';

export function init(elem, dotNetObject) {
    elem._select = MDCSelect.attachTo(elem);

    elem._select.foundation.handleMenuItemAction = index => {
        elem._select.foundation.setSelectedIndex(index);
        dotNetObject.invokeMethodAsync('NotifySelectedAsync', index);
    };
}

export function destroy(elem) {
    elem._select.destroy();
}

export function setDisabled(elem, value) {
    elem._select.disabled = value;
}

export function setIndex(elem, index) {
    elem._select.selectedIndex = index;
}
