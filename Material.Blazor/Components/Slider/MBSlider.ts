﻿import { MDCSlider } from '@material/slider';
import { debounce, throttle } from '../../Scripts/LodashParts';

export function init(elem, dotNetObject, eventType, delay) {
    elem._slider = MDCSlider.attachTo(elem);
    elem._eventType = eventType;

    if (eventType == 0) {
        const thumbUpCallback = () => {
            dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
        };
        elem._slider.listen('MDCSlider:change', thumbUpCallback);
    }
    else if (eventType == 1) {
        const debounceNotify = debounce(function () {
            dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
        }, delay, {});
        elem._slider.listen('MDCSlider:input', debounceNotify);
    }
    else {
        const throttleNotify = throttle(function () {
            dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
        }, delay, {});
        elem._slider.listen('MDCSlider:input', throttleNotify);
    }
}

export function setValue(elem, value) {
    elem._slider.setValue(value);
}

export function setDisabled(elem, value) {
    elem._slider.setDisabled(value);
}
