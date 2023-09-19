/*
MD3 JS
*/
import '@material/web/checkbox/checkbox.js';
import '@material/web/icon/icon.js';
import '@material/web/iconbutton/icon-button.js';
import '@material/web/progress/circular-progress.js';
import '@material/web/progress/linear-progress.js';
import '@material/web/radio/radio.js';
import '@material/web/textfield/filled-text-field.js';
import '@material/web/textfield/outlined-text-field.js';
import '@material/web/switch/switch.js';

import * as MBTextField from '../Components/TextField/MBTextField';
import * as MBTextField2 from '../Components/TextField2/MBTextField2';

/*
MD2 JS
*/
import * as MBCard from '../Components.MD2/Card/MBCard';
import * as MBDataTable from '../Components.MD2/DataTable/MBDataTable';
import * as MBDialog from '../Components.MD2/Dialog/MBDialog';
import * as MBDrawer from '../Components.MD2/Drawer/MBDrawer';
import * as MBIconButton from '../Components.MD2/IconButton/MBIconButton'
import * as MBMenu from '../Components.MD2/Menu/MBMenu';
import * as MBSelect from '../Components.MD2/Select/MBSelect';
import * as MBTopAppBar from '../Components.MD2/TopAppBar/MBTopAppBar';

(<any>window).MaterialBlazor = {
    MBTextField,
    MBTextField2,

    MBCard,
    MBDataTable,
    MBDialog,
    MBDrawer,
    MBIconButton,
    MBMenu,
    MBSelect,
    MBTopAppBar
};
