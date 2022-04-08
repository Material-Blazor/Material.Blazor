export function getElementDimensions(
    elementId: string,
    elements: number[]): number[] {

    // Create an element
    const ele: HTMLElement | null = document.getElementById(elementId);

    if (ele != null) {
        // Get the height
        var height: string = window.getComputedStyle(ele).height;
        var unadornedHeight: string = height.slice(0, height.indexOf("px"));
        var numericHeight: number = parseFloat(unadornedHeight);
        elements[0] = numericHeight;

        // Get the width
        var width: string = window.getComputedStyle(ele).width;
        var unadornedWidth: string = width.slice(0, width.indexOf("px"));
        var numericWidth: number = parseFloat(unadornedWidth);
        elements[1] = numericWidth;
    }

    return elements;
}
