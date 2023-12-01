import { CloseMenuEvent } from '@material/web/menu/internal/controllers/shared.js';
import { MdMenu } from '@material/web/menu/menu';

function reportMenuCloseEvent() {
    console.log("Menu close event");
}

//function reportMenuCloseEvent(cme: CloseMenuEvent) {
//    console.log("Menu close event");
//}

export function setMenuCloseEvent(menuID: string) {
    const menuElement: any | null = document.getElementById(menuID);
    if (menuElement != null) {
        console.log("Adding listener for menu-close events");
        menuElement.addEventListener('menu-close', () => { reportMenuCloseEvent(); });
    }
}

function toggleMenu(menuElement: any) {
    console.log("toggleMenu invoked");
    if (menuElement != null) {
        menuElement.open = !menuElement.open;
    }
}
export function toggleMenuOpen(menuButtonID: string, menuID: string) {
    const buttonElement: HTMLElement | null = document.getElementById(menuButtonID);
    const menuElement: any | null = document.getElementById(menuID);
    if ((buttonElement != null) && (menuElement != null)) {
        console.log("Adding listener for click events");
        buttonElement.addEventListener('click', () => { toggleMenu(menuElement) });
    }
}
