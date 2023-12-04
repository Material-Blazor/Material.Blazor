import { CloseMenuEvent } from '@material/web/menu/internal/controllers/shared.js';
//import { MdButton } from '@material/web/button/button';
import { MdMenu } from '@material/web/menu/menu';

function reportMenuCloseEvent() {
    console.log("Menu close event");
}

//function reportMenuCloseEvent(cme: CloseMenuEvent) {
//    console.log("Menu close event");
//}

export function setMenuCloseEvent(menuID: string) {
    const menuElement: MdMenu | null = (document.getElementById(menuID) as MdMenu);
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
export function setToggleMenuOpen(menuButtonID: string, menuID: string) {
    const buttonElement: HTMLElement | null = document.getElementById(menuButtonID);
    const menuElement: MdMenu | null = (document.getElementById(menuID) as MdMenu);
    if ((buttonElement != null) && (menuElement != null)) {
        console.log("Adding listener for click events");
        buttonElement.addEventListener('click', () => { toggleMenu(menuElement) });
    }
}
