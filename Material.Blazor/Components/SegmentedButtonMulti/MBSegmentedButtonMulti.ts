import { MDCSegmentedButton } from '@material/segmented-button';

export function init(elem, dotNetObject) {
    elem._segmentedButton = MDCSegmentedButton.attachTo(elem);
    var x = dotNetObject;
    //return new Promise(() => {
    //    elem._segmentedButton.foundation.handleMenuItemAction = index => {
    //        elem._segmentedButton.foundation.setSelectedIndex(index);
    //        dotNetObject.invokeMethodAsync('NotifySelectedAsync', index);
    //    };
    //});
}

export function destroy(elem) {
    elem._segmentedButton.destroy();
}

export function setDisabled(elem, value) {
    elem._segmentedButton.disabled = value;
}

export function setIndex(elem, index) {
    elem._segmentedButton.selectedIndex = index;
}
