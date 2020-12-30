function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

export async function openBlade(bladeSetElem, mainContentElem, scrollHelperElem, bladeElem, bladeContentElem, transitionMs): Promise<void> {
    const transition = "width " + transitionMs + "ms";

    let bladeSetWidth = bladeSetElem.getBoundingClientRect().width;
    let bladeContentWidth = bladeContentElem.getBoundingClientRect().width;
    let mainContentWidth = getComputedStyle(mainContentElem).width;
    let mainContentMinWidth = getComputedStyle(mainContentElem).minWidth;
    
    let availableShrinkage = bladeContentWidth;
    bladeElem.style.transition = transition;
    
    if (mainContentMinWidth.substring(mainContentMinWidth.length - 2, mainContentMinWidth.length) == "px") {
        availableShrinkage = Math.min(bladeContentWidth, parseInt(mainContentWidth) - parseInt(mainContentMinWidth));
    }

    if (false && availableShrinkage < bladeContentWidth) {
        let scrollHelperWidth = bladeContentWidth - availableShrinkage;
        scrollHelperElem.style.transition = "";
        scrollHelperElem.style.width = scrollHelperWidth + "px";
        scrollHelperElem.style.transition = transition;

        bladeSetWidth += availableShrinkage;
        bladeSetElem.style.width = bladeSetWidth + "px";
        
        bladeSetElem.scrollBy({
            top: 0,
            left: scrollHelperWidth,
            behavior: "auto"
        });

        scrollHelperElem.style.width = "0px";
    }

    bladeElem.style.width = bladeContentWidth + "px";

    bladeElem.scrollIntoView();

    for (let i = 0; i < transitionMs; i++) {
        await sleep(1);
        bladeElem.scrollIntoView();
    }

    //await sleep(transitionMs);

    //bladeSetElem.style.width = "";
}

export function closeBlade(bladeElem): void {
    bladeElem.style.width = "0px";
}