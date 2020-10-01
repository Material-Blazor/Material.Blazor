window.OldMaterialBlazor = {
    MBTooltip: {
        init: function (arrayOfReferences) {
            arrayOfReferences
                .filter(f => f.__internalId !== null) // Not really needed
                .forEach(i => mdc.tooltip.MDCTooltip.attachTo(i));
        }
    }

};