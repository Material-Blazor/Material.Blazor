    /*
    ** The source file "material.blazor.custom.events.ts" is processed by webpack to become
    ** 'Material.Blazor.MD3.lib.module.NEEDS.EDIT.AND.COPY.js'.
    ** 
    ** After being created the module code must be removed and 'export' must be added to the
    ** two function calls. The file is then copied to 'Material.Blazor.MD3.lib.module.js'.
    **
    ** 'Material.Blazor.MD3.lib.module.js' is checked into the repository in order to insure
    ** inclusion as a static asset of M.B.MD3 and to prevent the publish step of M.B.MD3.W.S from failure
    ** due to a dotnet tooling ussue.
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
