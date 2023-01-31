import '@material/web/icon/icon.js';
import '@material/web/textfield/filled-text-field.js';
import '@material/web/textfield/outlined-text-field.js';

import * as MBCard from '../Components.MD2/Card/MBCard';
import * as MBDataTable from '../Components.MD2/DataTable/MBDataTable';
import * as MBDialog from '../Components.MD2/Dialog/MBDialog';
import * as MBDrawer from '../Components.MD2/Drawer/MBDrawer';
import * as MBIconButton from '../Components.MD2/IconButton/MBIconButton'
import * as MBMenu from '../Components.MD2/Menu/MBMenu';
import * as MBRadioButton from '../Components.MD2/RadioButton/MBRadioButton';
import * as MBSelect from '../Components.MD2/Select/MBSelect';
import * as MBSnackbar from '../Components.MD2/Snackbar/MBSnackbar';
import * as MBSwitch from '../Components.MD2/Switch/MBSwitch';
import * as MBTopAppBar from '../Components.MD2/TopAppBar/MBTopAppBar';

import * as InternalTextFieldBase from '../Components/TextField/InternalTextFieldBase';

(<any>window).MaterialBlazor = {
    InternalTextFieldBase,

    MBCard,
    MBDataTable,
    MBDialog,
    MBDrawer,
    MBIconButton,
    MBMenu,
    MBRadioButton,
    MBSelect,
    MBSnackbar,
    MBSwitch,
    MBTopAppBar
};
