window.OldMaterialBlazor = {
    MBTooltip: {
        init: function (arrayOfReferences) {
            arrayOfReferences.forEach(i => mdc.tooltip.MDCTooltip.attachTo(i));
        }
    }

};