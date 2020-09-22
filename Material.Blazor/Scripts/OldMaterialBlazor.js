window.OldMaterialBlazor = {
    MBTooltip: {
        init: function (elems) {
            elems
                .filter(f => f.__internalId !== null)
                .forEach(i => mdc.tooltip.MDCTooltip.attachTo(i));
        }
    }

};