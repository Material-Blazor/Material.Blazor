import { MDCTabBar } from '@material/tab-bar';

export function init(elem, dotNetObject) {
    elem._tabBar = MDCTabBar.attachTo(elem);

    elem._callback = () => {
        let index = elem._tabBar.foundation.adapter.getFocusedTabIndex();
        dotNetObject.invokeMethodAsync('NotifyActivatedAsync', index);
    };

    elem._tabBar.listen('MDCTabBar:activated', elem._callback);
}

export function activateTab(elem, index) {
    elem._tabBar.unlisten('MDCTabBar:activated', elem._callback);
    elem._tabBar.activateTab(index);
    elem._tabBar.listen('MDCTabBar:activated', elem._callback);
}
