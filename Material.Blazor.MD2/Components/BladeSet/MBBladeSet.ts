const fps = 60;
const waitDelay = 1000 / fps;

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

export async function openBlade(bladeElem, bladeContentElem, transitionMs): Promise<void> {
    if (!bladeElem || !bladeContentElem) {
        return;
    }
    let transition = "width " + transitionMs + "ms";
    let bladeContentWidth = bladeContentElem.getBoundingClientRect().width;
    
    bladeElem.style.transition = transition;
    bladeElem.style.width = bladeContentWidth + "px";
    bladeElem.scrollIntoView();

    let intervals = Math.ceil(transitionMs / waitDelay) + 1;

    for (let i = 0; i < intervals; i++) {
        await sleep(waitDelay);
        bladeElem.scrollIntoView();
    }
}

export function closeBlade(bladeElem): void {
    if (!bladeElem) {
        return;
    }
    bladeElem.style.width = "0px";
}