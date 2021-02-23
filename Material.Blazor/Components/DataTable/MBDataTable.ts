import { MDCDataTable } from '@material/data-table';

export function init(elem, hasProgress, showProgress) {
    elem._dataTable = MDCDataTable.attachTo(elem);
    if (hasProgress) {
       setProgress(elem, showProgress);
    }
}

export function destroy(elem) {
    elem?._dataTable?.destroy();
}

export function setProgress(elem, showProgress) {
    if (showProgress) {
        elem._dataTable.showProgress();
    }
    else {
        elem._dataTable.hideProgress();
    }
}
