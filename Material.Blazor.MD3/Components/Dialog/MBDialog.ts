import { MdDialog } from '@material/web/dialog/dialog';

export function dialogShow(dialogID: string, dotNetObject: any, gestureCancellation: boolean) {
    //    const dialogElement: MdDialog | null = (document.getElementById(dialogID) as MdDialog);
    const dialogElement: any | null = document.getElementById(dialogID);
    if (dialogElement != null) {
        dialogElement._dotNetObject = dotNetObject;
        dialogElement._gestureCancellation = gestureCancellation;

        console.log("Adding listener for dialog closed events");
        const closedCallback = () => {
            console.log("Dialog close event");
            dialogElement.removeEventListener('close', closedCallback);
            dialogElement._dotNetObject.invokeMethodAsync('NotifyClosed', dialogElement.returnValue);
        };
        dialogElement.addEventListener('closed', closedCallback);

        console.log("Adding listener for dialog cancel events");
        dialogElement.addEventListener('cancel', event => {
            event.preventDefault(); // Stop cancellation gestures from closing dialog
            if (dialogElement._gestureCancellation) {
                dialogElement.close('cancel'); // Update `returnValue` to handle cancellation logic
            }
        });

        dialogElement.show();
    }
}

export function dialogClose(dialogID: string) {
    (document.getElementById(dialogID) as MdDialog)?.close("cancel");
}
