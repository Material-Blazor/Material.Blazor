export function isRTL(elem): boolean {
    let dirElem = elem;
    let dir = null;

    for (; dirElem && dirElem !== document && !dir; dirElem = dirElem.parentNode) {
        dir = dirElem.getAttribute('dir');
    }

    return dir === 'rtl';
}
