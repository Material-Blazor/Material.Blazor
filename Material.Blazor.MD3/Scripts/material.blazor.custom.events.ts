/*
** The source file "material.blazor.custom.events.ts" is processed by webpack to become
** 'Material.Blazor.MD3.lib.module.NEEDS.EDIT.AND.COPY.js'.
** 
** After being created the module code must be removed and 'export' must be added to the
** two function calls. The file is then copied to 'Material.Blazor.MD3.lib.module.js'.
*/

import { CloseMenuEvent } from '@material/web/menu/internal/controllers/shared.js';
import { MenuItem } from '@material/web/menu/menu.js';

/*
** MW3 close-menu event arguments
**
** This must match the C# definition found in MBMenuEvents.cs
*/
export function eventArgsCreatorMenuSelectionReport(event: CloseMenuEvent) {
    var target: MenuItem = event.target as unknown as MenuItem;
    return {
        menuID: target.id,
        menuHeadline: target.typeaheadText,
        reason: JSON.stringify(event.detail.reason)
    };
}

/*
** Register all custom events
*/
export function afterStarted(blazor) {
    console.log("Registering menuselectionreport event");
    blazor.registerCustomEventType('menuselectionreport', {
        browserEventName: "close-menu",
        createEventArgs: eventArgsCreatorMenuSelectionReport
    });
}
