import { MDCSlider } from '@material/slider';
import * as _ from "lodash";

export function init(elem, dotNetObject, eventType, delay) {
    elem._slider = MDCSlider.attachTo(elem);
    elem._eventType = eventType;

    let debounceNotify = _.debounce(function () {
        dotNetObject.invokeMethodAsync('NotifyChangedAsync', elem._slider.getValue());
    }, delay); 

    let throttleNotify = _.throttle(function () {
        dotNetObject.invokeMethodAsync('NotifyChangedAsync', elem._slider.getValue());
    }, delay); 

    const thumbUpCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyChangedAsync', elem._slider.getValue());
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

export function destroy(elem) {
    elem._slider.destroy();
}

export function setValue(elem, value) {
    elem._slider.setValue(value);
}

export function setDisabled(elem, value) {
    elem._slider.setDisabled(value);
}
