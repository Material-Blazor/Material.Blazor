import { MdTabs } from '@material/web/tabs/tabs.js';

// Because of invocation of setTabsChangeEvent in AfterRenderAsync the first change is not detected. The workaround is to
// lookup the first panel by name

export function setTabsChangeEvent(tabsID: string, firstPanelAriaControlledBy: string) {
    const firstPanel = firstPanelAriaControlledBy;
    const tabsElement: MdTabs | null = (document.getElementById(tabsID) as MdTabs);
    if (tabsElement != null) {
        console.log("Adding listener for change events");
        let currentPanel: HTMLElement | null = null;
        tabsElement.addEventListener('change', () => {
            const root = tabsElement.getRootNode() as Document | ShadowRoot;

            if (currentPanel) {
                //console.log("currentPanel is not null, direct hide");
                currentPanel.hidden = true;
            }
            else {
                //console.log("currentPanel is null, looking up first panel by '" + firstPanel + "'");
                currentPanel = root.querySelector<HTMLElement>(`#${firstPanel}`);
                if (currentPanel) {
                    currentPanel.hidden = true;
                }
            };

            const panelId = tabsElement.activeTab?.getAttribute('aria-controls');
            currentPanel = root.querySelector<HTMLElement>(`#${panelId}`);
            if (currentPanel) {
                currentPanel.hidden = false;
            }
        });
    };
}

