export function isRTL(elem): boolean {
    if (!elem) {
        return false;
    }

    let dirElem = elem;
    let dir = null;

    for (; dirElem && dirElem !== document && !dir; dirElem = dirElem.parentNode) {
        dir = dirElem.getAttribute('dir');
    }

    return dir === 'rtl';
}
