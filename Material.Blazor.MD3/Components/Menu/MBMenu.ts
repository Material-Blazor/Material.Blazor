import { CloseMenuEvent } from '@material/web/menu/internal/controllers/shared.js';
import { MenuItem } from '@material/web/menu/menu.js';

/**
 * Searches for an element with `class="output"` set on it, and updates the
 * text of that element with the menu-closed event content.
 */
function displayCloseMenuEvent(event: CloseMenuEvent) {
    console.log("displayCloseMenuEvent invoked");
    // get the output element from the shadow root
    const root = (event.target as HTMLElement).getRootNode() as ShadowRoot;
    const outputEl = root.querySelector('.output') as HTMLElement;

    const stringifyItem = (menuItem: MenuItem & HTMLElement) => {
        const tagName = menuItem.tagName.toLowerCase();
        const headline = menuItem.typeaheadText;
        return `${tagName}${menuItem.id ? `[id="${menuItem.id}"]` : ''
            } > [slot="headline"] > ${headline}`;
    };

    // display the event's details in the inner text of that output element
    outputEl.textContent = `CustomEvent {
  type: ${event.type},
  target: ${stringifyItem(event.target as unknown as MenuItem)},
  detail: {
    initiator: ${stringifyItem(event.detail.initiator)},
    itemPath: [
      ${event.detail.itemPath.map((item) => stringifyItem(item)).join(`,
      `)}
    ],
  },
  reason: ${JSON.stringify(event.detail.reason)}
}`;
}

export function setMenuEventListeners(anchorID: string, menuID: string) {
    const anchorElement: HTMLElement | null = document.getElementById(anchorID);
    const menuElement: HTMLElement | null = document.getElementById(menuID);
    if ((anchorElement != null) && (menuElement != null)) {
        console.log("Adding listener for anchor click events");
        anchorElement.addEventListener('click', () => { toggleMenu(menuElement) });
    }
}

function toggleMenu(menuElement: any) {
    console.log("toggleMenu invoked");
    if (menuElement != null) {
        menuElement.open = !menuElement.open;
    }
}
