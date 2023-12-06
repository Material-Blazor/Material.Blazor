import { MdDialog } from '@material/web/dialog/dialog';

export function dialogShow(dialogID: string, dotNetObject: any, escapeKeyAction: any, scrimClickAction: any) {
    (document.getElementById(dialogID) as MdDialog)?.show();
    //    const dialogElement: MdDialog | null = (document.getElementById(dialogID) as MdDialog);
    const dialogElement: any | null = document.getElementById(dialogID);
    if (dialogElement != null) {
        dialogElement._dialog = dialogElement;
        dialogElement._dotNetObject = dotNetObject;
        dialogElement._escapeKeyAction = escapeKeyAction;
        dialogElement._scrimClickAction = scrimClickAction;
        //dialogElement.returnValue = "";

        console.log("Adding listener for dialog closed events");
        const closedCallback = () => {
            console.log("Dialog close event");
            dialogElement.removeEventListener('close', closedCallback);
            dialogElement._dotNetObject.invokeMethodAsync('NotifyClosed', dialogElement.returnValue);
        };
        dialogElement.addEventListener('closed', closedCallback);

        dialogElement.show();
    }
}
