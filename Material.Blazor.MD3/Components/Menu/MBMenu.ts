export function setMenuOpen(menuButtonID: string, menuID: string) {
    const buttonElement: HTMLElement | null = document.getElementById(menuButtonID);
    const menuElement: any | null = document.getElementById(menuID);
    if ((buttonElement != null) && (menuElement != null)) {
        buttonElement.addEventListener('click', () => { menuElement.open = !menuElement.open; });
    }
}
