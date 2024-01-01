/*
MW3 JS
*/
import '@material/web/all.js';

/*
M.B.MD3 JS
*/
import * as MBDialog from '../Components/Dialog/MBDialog';
import * as MBGrid from '../Components/Grid/MBGrid';
import * as MBMenu from '../Components/Menu/MBMenu';
import * as MBTabs from '../Components/Tabs/MBTabs';
import * as MBTextField from '../Components/TextField/MBTextField';

/*
MWC2 JS
*/
import * as MBCard from '../Components.MD2/Card/MBCard';
import * as MBDataTable from '../Components.MD2/DataTable/MBDataTable';
import * as MBDrawer from '../Components.MD2/Drawer/MBDrawer';
import * as MBMenuMD2 from '../Components.MD2/Menu/MBMenu';
import * as MBTopAppBar from '../Components.MD2/TopAppBar/MBTopAppBar';

(<any>window).MaterialBlazor = {
    MBDialog,
    MBGrid,
    MBMenu,
    MBTabs,
    MBTextField,

    MBCard,
    MBDataTable,
    MBDrawer,
    MBMenuMD2,
    MBTopAppBar
};
