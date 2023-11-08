export function toggleDialogOpen(dialogID: string) {
    const dialogElement: any | null = document.getElementById(dialogID);
    if (dialogElement != null) {
        dialogElement.open = !dialogElement.open;
    }
}
