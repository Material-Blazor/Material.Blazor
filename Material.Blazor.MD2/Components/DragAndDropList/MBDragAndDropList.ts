export function initDropTarget(elem): void {
    if (!elem) {
        return;
    }

    elem.addEventListener('dragover', event =>
    {
        event.preventDefault();
    });
}
