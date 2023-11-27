import { CloseMenuEvent } from '@material/web/menu/internal/controllers/shared.js';

function reportMenuCloseEvent(cme: CloseMenuEvent) {
    console.log("Menu close event");
}

export function setMenuCloseEvent(menuID: string) {
    const menuElement: any | null = document.getElementById(menuID);
    if (menuElement != null) {
        console.log("Adding listener for menu-close events");
        menuElement.addEventListener('menu-close', () => { reportMenuCloseEvent(); });
    }
}

export function toggleMenuOpen(menuButtonID: string, menuID: string) {
    const buttonElement: HTMLElement | null = document.getElementById(menuButtonID);
    const menuElement: any | null = document.getElementById(menuID);
    if ((buttonElement != null) && (menuElement != null)) {
        console.log("Adding listener for click events");
        buttonElement.addEventListener('click', () => { menuElement.open = !menuElement.open; });
    }
}
