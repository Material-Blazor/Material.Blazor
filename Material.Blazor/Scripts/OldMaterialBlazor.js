window.OldMaterialBlazor = {
    MBTooltip: {
        init: function (arrayOfReferences) {
            arrayOfReferences.forEach(elem => elem._tooltip = mdc.tooltip.MDCTooltip.attachTo(elem));
        },

        destroy(elem) {
            elem._tooltip.destroy();
        }
    }
};