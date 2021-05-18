import { MDCSlider } from '@material/slider';
import * as _ from '../../Scripts/LodashParts';

export function init(elem, dotNetObject, eventType, delay) {
    elem._slider = MDCSlider.attachTo(elem);
    elem._eventType = eventType;
    let debounceNotify = _.debounce(function () {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    }, delay, {}); 

    let throttleNotify = _.throttle(function () {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    }, delay, {}); 

    const thumbUpCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    };

    const debounceCallback = () => {
        debounceNotify();
    };

    const throttleCallback = () => {
        throttleNotify();
    };

    if (eventType == 0) {
        elem._slider.listen('MDCSlider:change', thumbUpCallback);
    }
    else if (eventType == 1) {
        elem._slider.listen('MDCSlider:input', debounceCallback);
    }
    else {
        elem._slider.listen('MDCSlider:input', throttleCallback);
    }
}

export function setValue(elem, value) {
    elem._slider.setValue(value);
}

export function setDisabled(elem, value) {
    elem._slider.setDisabled(value);
}
