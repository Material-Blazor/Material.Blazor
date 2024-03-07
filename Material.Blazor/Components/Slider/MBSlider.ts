import { MDCSlider } from '@material/slider';
import { debounce, throttle } from '../../Scripts/lodashparts';
import { isElementRTL } from '../../Scripts/rtl';

export function init(mainElem, thumbElem, thumbOffset, dotNetObject, eventType, delay, disabled) {
    if (!mainElem || !thumbElem) {
        return;
    }

    thumbElem.style = (isElementRTL(mainElem) ? "right: " : "left: ") + thumbOffset;

    mainElem._slider = MDCSlider.attachTo(mainElem);
    mainElem._eventType = eventType;

    if (eventType == 0) {
        const thumbUpCallback = () => {
            dotNetObject.invokeMethodAsync('NotifyChanged', mainElem._slider.getValue());
        };

        mainElem._slider.listen('MDCSlider:change', thumbUpCallback);
    }
    else if (eventType == 1) {
        const debounceNotify = debounce(function () {
            dotNetObject.invokeMethodAsync('NotifyChanged', mainElem._slider.getValue());
        }, delay, {});

        mainElem._slider.listen('MDCSlider:input', debounceNotify);
    }
    else {
        const throttleNotify = throttle(function () {
            dotNetObject.invokeMethodAsync('NotifyChanged', mainElem._slider.getValue());
        }, delay, {});

        mainElem._slider.listen('MDCSlider:input', throttleNotify);
    }

    mainElem._slider.setDisabled(disabled);
}

export function setValue(elem, value) {
    if (!elem) {
        return;
    }
    elem._slider.setValue(value);
}

export function setDisabled(elem, disabled) {
    if (!elem) {
        return;
    }
    elem._slider.setDisabled(disabled);
}