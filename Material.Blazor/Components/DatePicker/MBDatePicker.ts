import { MDCSelect } from '@material/select';
import { MDCMenuSurface } from '@material/menu-surface';

export function init(elem, menuSurfaceElem, dotNetObject) {
    if (!elem || !menuSurfaceElem) {
        return;
    }

    elem._select = MDCSelect.attachTo(elem);
    elem._menuSurface = MDCMenuSurface.attachTo(menuSurfaceElem);

    const openCallback = () => {
        elem._menuSurface.unlisten('MDCMenuSurface:opened', openCallback);
        dotNetObject.invokeMethodAsync('NotifyOpened');
    };

    elem._menuSurface.listen('MDCMenuSurface:opened', openCallback);
}

export function setDisabled(elem, value) {
    if (!elem) {
        return;
    }
    elem._select.disabled = value;
}

export function listItemClick(elem, elemText) {
    if (!elem) {
        return;
    }
    elem.innerText = elemText;
    elem.click();
}

function tryScrollToYear(id, attempt: number) {
    setTimeout(() => {
        var element = document.getElementById(id);
        if (element) {
            element.scrollIntoView({ behavior: 'auto', block: 'nearest', inline: 'nearest' });
        } else {
            if (attempt < 10) {
                tryScrollToYear(id, attempt + 1);
            }
        }
    }, 16);
}

export function scrollToYear(id) {
    // we allow up to 10 attempts every 16ms, because Virtualize may have not yet rendered the year we want to scroll to.
    tryScrollToYear(id, 0);
}

export function isRTL(elem): boolean {
    let dirElem = elem;
    let dir = null;

    for (; dirElem && dirElem !== document && !dir; dirElem = dirElem.parentNode) {
        dir = dirElem.getAttribute('dir');
    }

    return dir === 'rtl';
}