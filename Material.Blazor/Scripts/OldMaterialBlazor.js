window.OldMaterialBlazor = {
    MBTooltip: {
        init: function (arraysOfReferences) {
            arraysOfReferences
                .filter(f => f.__internalId !== null)
                .forEach(i => mdc.tooltip.MDCTooltip.attachTo(i));
        }
    }

};