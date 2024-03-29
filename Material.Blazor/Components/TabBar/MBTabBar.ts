﻿import { MDCTabBar } from '@material/tab-bar';

export function init(elem, dotNetObject) {
    if (!elem) {
        return;
    }
    elem._tabBar = MDCTabBar.attachTo(elem);

    elem._callback = () => {
        let index = elem._tabBar.foundation.adapter.getFocusedTabIndex();
        dotNetObject.invokeMethodAsync('NotifyActivated', index);
    };

    elem._tabBar.listen('MDCTabBar:activated', elem._callback);
}

export function activateTab(elem, index) {
    if (!elem) {
        return;
    }
    elem._tabBar.unlisten('MDCTabBar:activated', elem._callback);
    elem._tabBar.activateTab(index);
    elem._tabBar.listen('MDCTabBar:activated', elem._callback);
}
