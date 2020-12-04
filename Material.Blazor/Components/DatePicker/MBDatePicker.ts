import { MDCSelect } from '@material/select';

export function init(elem) {
    elem._select = MDCSelect.attachTo(elem);
}

export function destroy(elem) {
    elem._select.destroy();
}

export function listItemClick(elem, elemText) {
    elem.innerText = elemText;
    elem.click();
}

export function scrollToYear(id) {
    var element = document.getElementById(id);
    element?.scrollIntoView({ behavior: 'smooth', block: 'center', inline: 'start' });
}
