import { MDCSegmentedButton } from '@material/segmented-button';

export function init(elem, isSingleSelect, dotNetObject) {
    elem._segmentedButton = MDCSegmentedButton.attachTo(elem);
    elem._isSingleSelect = isSingleSelect;

    return new Promise(() => {
        elem._segmentedButton.foundation.handleSelected = index => {
            if (elem._isSingleSelect) {
                dotNetObject.invokeMethodAsync('NotifySingleSelectedAsync', index.index);

                for (let i = 0; i < elem._segmentedButton.segments_.length; i++) {
                    if (i == index) {
                        elem._segmentedButton.segments_[i].setSelected();
                    }
                    else {
                        elem._segmentedButton.segments_[i].setUnselected();
                    }
                }
            }
            else {
                dotNetObject.invokeMethodAsync('NotifyMultiSelectedAsync', elem._segmentedButton.segments_.map(x => x.isSelected()));
            }
        };
    });
}

export function destroy(elem) {
    elem._segmentedButton.destroy();
}

export function setDisabled(elem, value) {
    elem._segmentedButton.disabled = value;
}

export function setSelected(elem, selectedFlags) {
    for (let i = 0; i < selectedFlags.length; i++) {
        if (selectedFlags[i] == true) {
            elem._segmentedButton.segments_[i].setSelected();
        }
        else {
            elem._segmentedButton.segments_[i].setUnselected();
        }
    }
}
