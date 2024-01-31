/*
** The source file "material.blazor.custom.events.ts" is processed by webpack to become
** 'Material.Blazor.MD3.lib.module.ts'.
** 
** After being created the module code must be removed and 'export' must be added to the
** two function calls.
*/

/*
** MW3 close-menu event arguments
**
** This must match the C# definition found in MBMenuEvents.cs
*/
export function eventArgsCreatorMenuSelectionReport(event) {
  var target = event.target;
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
