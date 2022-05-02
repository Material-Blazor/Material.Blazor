import { MDCChipSet } from '@material/chips';
import { MDCChipActionType } from '@material/chips/action/constants';

export function init(elem, isMultiSelect, dotNetObject) {
    if (!elem) {
        return;
    }
    elem._chipSet = MDCChipSet.attachTo(elem);
    elem._isMultiSelect = isMultiSelect;

    const clickedCallback = () => {
        if (elem._isMultiSelect) {
            dotNetObject.invokeMethodAsync('NotifyMultiSelected', Array.from(elem._chipSet.getSelectedChipIndexes()));
            //dotNetObject.invokeMethodAsync('NotifyMultiSelected', elem._chipSet.chips.map(x => x.isActionSelected(0)));
        }
        else {
            let result = -1;

            for (let i = 0; i < elem._chipSet.chips.length; i++) {
                if (elem._chipSet.chips[i].foundation.isActionSelected(MDCChipActionType.PRIMARY)) {
                    result = i;
                }
            }

            dotNetObject.invokeMethodAsync('NotifySingleSelected', result);

            //var selectedChips = elem._chipSet.chips.filter(x => x.isActionSelected(0));

            //if (selectedChips.length == 0) {
            //    dotNetObject.invokeMethodAsync('NotifySingleSelected', -1);
            //}
            //else {
            //    dotNetObject.invokeMethodAsync('NotifySingleSelected', elem._chipSet.chips.findIndex(x => x.id === selectedChips[0].id));
            //}
        }
    };

    elem._chipSet.listen('MDCChipSet:selection', clickedCallback);
}

export function setDisabled(elem, value) {
    if (!elem) {
        return;
    }
    elem._chipSet.disabled = value;
}

// This function doesn't appear to work properly - see https://github.com/Material-Blazor/Material.Blazor/issues/366
export function setSelected(elem, selectedFlags) {
    if (!elem) {
        return;
    }
    for (let i = 0; i < selectedFlags.length; i++) {
        //elem._chipSet.chips[i].selected = selectedFlags[i];
        elem._chipSet.foundation.adapter.selectChipAtIndex(i, selectedFlags[i], false);
        //elem._chipSet.chips[i].foundation.setSelectedFromChipSet(selectedFlags[i], false);
        //elem._chipSet.chips[i].foundation.notifySelection(selectedFlags[i], false);
    }
}
