import { MdDialog } from '@material/web/dialog/dialog';

export function dialogShow(dialogID: string) {
    (document.getElementById(dialogID) as MdDialog)?.show();
}
