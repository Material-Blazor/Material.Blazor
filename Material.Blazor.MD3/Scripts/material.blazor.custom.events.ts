/*
** MW3 menu-close event arguments
**
** This must match the C# definition found in MBMenuEvents.cs
*/
export function eventArgsCreatorMenuClose(event) {
    return {
        customProperty1: 'any value for property 1',
        customProperty2: event.srcElement.value
    };
}

/*
** Register all custom events
*/
export function afterStarted(blazor) {
    blazor.registerCustomEventType('menuclose', {
        browserEventName: "menu-close",
        createEventArgs: eventArgsCreatorMenuClose
    });
}
