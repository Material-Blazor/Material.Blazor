export function isDocumentRTL(): boolean {
    let dir = document.documentElement.getAttribute("dir");

    return !dir || dir.toLowerCase() === "rtl";
}

export function isElementRTL(elem): boolean {
    if (!elem) {
        return false;
    }

    let dirElem = elem;
    var dir = "";

    for (; dirElem && dirElem !== document && (!dir || dir === ""); dirElem = dirElem.parentNode) {
        dir = dirElem.getAttribute("dir");

        if (dir && dir.length > 0) {
            dir = dir.toLowerCase();

            if (dir === "ltr" || dir === "auto") {
                break;
            }
        }
    }

    return dir !== null && dir.toLowerCase() === "rtl";
}