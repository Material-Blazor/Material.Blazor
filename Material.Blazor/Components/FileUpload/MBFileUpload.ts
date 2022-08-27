export function click(elem) {
    if (!elem) {
        return;
    }

    var input = elem.querySelector("input");
    input.click();
}

