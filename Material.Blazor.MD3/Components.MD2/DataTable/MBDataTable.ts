import { MDCDataTable } from '@material/data-table';

export function init(elem) {
    if (!elem) {
        return;
    }
    elem._dataTable = MDCDataTable.attachTo(elem);
}
