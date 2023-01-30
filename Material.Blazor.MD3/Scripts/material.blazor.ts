import '@material/web/icon/icon.js';
import '@material/web/textfield/filled-text-field.js';
import '@material/web/textfield/outlined-text-field.js';

import * as MBCard from '../Components.MD2/Card/MBCard';
import * as MBDataTable from '../Components.MD2/DataTable/MBDataTable';
import * as MBDrawer from '../Components.MD2/Drawer/MBDrawer';
import * as MBMenu from '../Components.MD2/Menu/MBMenu';
import * as MBSnackbar from '../Components.MD2/Snackbar/MBSnackbar';
import * as MBTopAppBar from '../Components.MD2/TopAppBar/MBTopAppBar';

import * as InternalTextFieldBase from '../Components/TextField/InternalTextFieldBase';

(<any>window).MaterialBlazor = {
    InternalTextFieldBase,

    MBCard,
    MBDataTable,
    MBDrawer,
    MBMenu,
    MBSnackbar,
    MBTopAppBar
};
