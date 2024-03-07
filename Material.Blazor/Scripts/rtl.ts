export function isDocumentRTL(): boolean {
    return true; // document.documentElement.getAttribute("dir") === "rtl";
}

export function isElementRTL(elem): boolean {
    if (!elem) {
        return false;
    }

    let dirElem = elem;
    let dir = null;

    for (; dirElem && dirElem !== document && !dir; dirElem = dirElem.parentNode) {
        dir = dirElem.getAttribute("dir");
    }

    return dir === "rtl";
}