import { MDCChipSet } from '@material/chips';

export function init(elem, isSingleSelect, dotNetObject) {
    elem._chipSet = MDCChipSet.attachTo(elem);
    elem._isSingleSelect = isSingleSelect;
    
    return new Promise(() => {
        elem._chipSet.foundation.handleChipSelection = index => {
            var x = index;
            var y = dotNetObject;
            if (elem._isSingleSelect) {
                dotNetObject.invokeMethodAsync('NotifySingleSelectedAsync', index.index);

                for (let i = 0; i < elem._chipSet.chips_.length; i++) {
                    if (i == index) {
                        elem._chipSet.chips_[i].setSelected();
                    }
                    else {
                        elem._chipSet.chips_[i].setUnselected();
                    }
                }
            }
            else {
                dotNetObject.invokeMethodAsync('NotifyMultiSelectedAsync', elem._chipSet.chips_.map(x => x.foundation.isSelected()));
            }
        };
    });
}

export function destroy(elem) {
    elem._chipSet.destroy();
}

export function setDisabled(elem, value) {
    elem._chipSet.disabled = value;
}

export function setSelected(elem, selectedFlags) {
    for (let i = 0; i < selectedFlags.length; i++) {
        elem._chipSet.foundation.adapter.selectChipAtIndex(i, selectedFlags[i], false);
    }
}
