import { MDCSegmentedButton } from '@material/segmented-button';

export function init(elem, dotNetObject) {
    elem._segmentedButton = MDCSegmentedButton.attachTo(elem);
    var x = dotNetObject;

    return new Promise(() => {
        elem._segmentedButton.foundation.handleSelected = _ => {
            dotNetObject.invokeMethodAsync('NotifySelectedAsync', elem._segmentedButton.segments_.map(x => x.isSelected()));
        };
    });
}

export function destroy(elem) {
    elem._segmentedButton.destroy();
}

export function setDisabled(elem, value) {
    elem._segmentedButton.disabled = value;
}

export function setAreSelected(elem, areSelected) {
    for (let i = 0; i < areSelected.length; i++) {
        if (areSelected[i] == true) {
            elem._segmentedButton.segments_[i].setSelected();
        }
        else {
            elem._segmentedButton.segments_[i].setUnselected();
        }
    }
}
