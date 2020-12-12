export function syncScroll(gridHeaderRef: HTMLElement, gridBodyRef: HTMLElement) {
    gridHeaderRef.scrollLeft = gridBodyRef.scrollLeft;
}

export function getScrollBarWidth(): number {
    const firstDiv: HTMLDivElement = document.createElement("div");
    firstDiv.style.visibility = "hidden";
    firstDiv.style.overflow = "scroll";
    document.body.appendChild(firstDiv);
    const secondDiv: HTMLDivElement = document.createElement("div");
    firstDiv.appendChild(secondDiv);
    const n: number = firstDiv.offsetWidth - secondDiv.offsetWidth;
    if (firstDiv.parentNode != null) {
        firstDiv.parentNode.removeChild(firstDiv);
    }
    return n;
}

export function getTextWidth(className: string, textToMeasure: string): string {
    // Create an element
    const ele: HTMLDivElement = document.createElement('div');

    // Set styles
    ele.style.position = 'absolute';
    ele.style.visibility = 'hidden';
    ele.style.whiteSpace = 'nowrap';
    ele.style.left = '-9999px';

    // Set the class
    ele.className = className;
    ele.innerText = textToMeasure;

    // Append to the body
    document.body.appendChild(ele);

    // Get the width
    const width: string = window.getComputedStyle(ele).width;

    // Remove the element
    document.body.removeChild(ele);

    return width;}

export function setPaddingRight(elementRef: HTMLElement) {
    elementRef.style.paddingRight = getScrollBarWidth() + "px";
}

//export function setTDWidths(elementRef: HTMLElement, columnWidthList: number[]) {
//}
