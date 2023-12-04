import { MdDialog } from '@material/web/dialog/dialog';

export function dialogShow(dialogID: string) {
    (document.getElementById(dialogID) as MdDialog)?.show();
}

function reportDialogCloseEvent() {
    console.log("Dialog close event");
}

export function setDialogCloseEvent(dialogID: string) {
    const dialogElement: MdDialog | null = (document.getElementById(dialogID) as MdDialog);
    if (dialogElement != null) {
        console.log("Adding listener for dialog close events");
        dialogElement.addEventListener('close', () => { reportDialogCloseEvent(); });
    }
}
