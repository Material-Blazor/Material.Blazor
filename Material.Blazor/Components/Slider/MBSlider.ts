import { MDCSlider } from '@material/slider';
<<<<<<< HEAD
import { debounce, throttle } from '../../Scripts/LodashParts';
=======
import * as db from "lodash.debounce";
import * as th from "lodash.throttle";
>>>>>>> 8ba16e6ac409e05fd4a5ce4a8f7b06661c5c6af2

export function init(elem, dotNetObject, eventType, delay) {
    elem._slider = MDCSlider.attachTo(elem);
    elem._eventType = eventType;

<<<<<<< HEAD
=======
    let debounceNotify = db.debounce(function () {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    }, delay); 

    let throttleNotify = th.throttle(function () {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    }, delay); 

    const thumbUpCallback = () => {
        dotNetObject.invokeMethodAsync('NotifyChanged', elem._slider.getValue());
    };

    const debounceCallback = () => {
        debounceNotify();
    };

    const throttleCallback = () => {
        throttleNotify();
    };

>>>>>>> 8ba16e6ac409e05fd4a5ce4a8f7b06661c5c6af2
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
