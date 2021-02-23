import { MDCSegmentedButton } from '@material/segmented-button';

export function init(elem, isSingleSelect, dotNetObject) {
    elem._segmentedButton = MDCSegmentedButton.attachTo(elem);
    elem._isSingleSelect = isSingleSelect;

    elem._segmentedButton.foundation.adapter.notifySelectedChange = detail => {
        if (elem._isSingleSelect) {
            dotNetObject.invokeMethodAsync('NotifySingleSelectedAsync', detail.index);
        }
        else {
            dotNetObject.invokeMethodAsync('NotifyMultiSelectedAsync', elem._segmentedButton.segments.map(x => x.isSelected()));
        }
    };
}

export function destroy(elem) {
    elem?._segmentedButton?.destroy();
}

export function setDisabled(elem, value) {
    elem._segmentedButton.disabled = value;
}

export function setSelected(elem, selectedFlags) {
    for (let i = 0; i < selectedFlags.length; i++) {
        if (selectedFlags[i] == true) {
            elem._segmentedButton.segments[i].setSelected();
        }
        else {
            elem._segmentedButton.segments[i].setUnselected();
        }
    }
}
