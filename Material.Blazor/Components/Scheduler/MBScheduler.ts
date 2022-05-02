export function getElementDimensions(
    elementId: string): number[] {

    // Create an element
    const element: HTMLElement | null = document.getElementById(elementId);
    var retval: number[] = new Array(2);

    if (element != null) {
        // Get the height
        var height: string = window.getComputedStyle(element).height;
        var unadornedHeight: string = height.slice(0, height.indexOf("px"));
        var numericHeight: number = parseFloat(unadornedHeight);
        retval[0] = numericHeight;

        // Get the width
        var width: string = window.getComputedStyle(element).width;
        var unadornedWidth: string = width.slice(0, width.indexOf("px"));
        var numericWidth: number = parseFloat(unadornedWidth);
        retval[1] = numericWidth;
    }

    return retval;
}

export function getElementBoundingClientRect(
    elementId: string): DOMRect | null {

    // Create an element
    const element: HTMLElement | null = document.getElementById(elementId);

    if (element != null) {
        // Get the bounding rectangle
        return element.getBoundingClientRect();
    }

    return null;
}
