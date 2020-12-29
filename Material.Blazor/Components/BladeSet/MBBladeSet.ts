export function openBlade(bladeSetElem, mainContentElem, scrollHelperElem, bladeElem, bladeContentElem): void {
    let bladeContentWidth = bladeContentElem.getBoundingClientRect().width;
    let mainContentWidth = getComputedStyle(mainContentElem).width;
    let mainContentMinWidth = getComputedStyle(mainContentElem).minWidth;

    let availableShrinkage = bladeContentWidth;

    if (mainContentMinWidth.substring(mainContentMinWidth.length - 2, mainContentMinWidth.length) == "px") {
        availableShrinkage = Math.min(bladeContentWidth, parseInt(mainContentWidth) - parseInt(mainContentMinWidth));
    }

    if (availableShrinkage < bladeContentWidth) {
        scrollHelperElem.style.transition = "";
        scrollHelperElem.style.width = bladeContentWidth + "px";

        bladeSetElem.scrollBy({
            top: 0,
            left: 5000,
            behavior: "auto"
        });

        scrollHelperElem.style.transition = "width 200ms";
        scrollHelperElem.style.width = "0px";
    }

    bladeElem.style.width = bladeContentWidth + "px";
}

export function closeBlade(bladeElem): void {
    bladeElem.style.width = "0px";
}