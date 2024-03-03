/*
MW3 JS
*/
import '@material/web/all.js';

/*
M.B.MD3 JS
*/
import * as MBDialog from '../Components/Dialog/MBDialog';
import * as MBMenu from '../Components/Menu/MBMenu';
import * as MBTabs from '../Components/Tabs/MBTabs';
import * as MBTextField from '../Components/TextField/MBTextField';

/*
MWC2 JS
*/
import * as MBCard from '../Components.MD2/Card/MBCard';
import * as MBDataTable from '../Components.MD2/DataTable/MBDataTable';

(<any>window).MaterialBlazor = {
    MBDialog,
    MBMenu,
    MBTabs,
    MBTextField,

    MBCard,
    MBDataTable
};
