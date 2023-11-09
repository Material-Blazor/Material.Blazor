export function dialogShow(dialogID: string) {
    const dialogElement: any | null = document.getElementById(dialogID);
    if (dialogElement != null) {
        dialogElement.open();
    }
}

export function dialogHide(dialogID: string) {
    const dialogElement: any | null = document.getElementById(dialogID);
    if (dialogElement != null) {
        dialogElement.close();
    }
}
