window.material_blazor = {
    menu: {
        init: function (elem, dotNetObject) {
            elem._menu = mdc.menu.MDCMenu.attachTo(elem);

            return new Promise(() => {
                elem._menu.foundation.handleItemAction = () => {
                    elem._menu.open = false;
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };
            });
        },

        show: function (elem) {
            if (elem._menu) {
                elem._menu.open = true;
            }
        },

        hide: function (elem) {
            if (elem._menu) {
                elem._menu.open = false;
            }
        }
    },

    radioButton: {
        init: function (elem, formFieldElem, isChecked) {
            elem._radio = mdc.radio.MDCRadio.attachTo(elem);
            elem._radio.checked = isChecked;
            let formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
            formField.input = elem._radio;
        },

        setChecked: function (elem, isChecked) {
            elem._radio.checked = isChecked;
        }
    },

    select: {
        init: function (selectElem, dotNetObject) {
            selectElem._select = mdc.select.MDCSelect.attachTo(selectElem);

            return new Promise(() => {
                selectElem._select.foundation.handleMenuItemAction = index => {
                    selectElem._select.foundation.setSelectedIndex(index);
                    dotNetObject.invokeMethodAsync('NotifySelectedAsync', index);
                };
            });
        },

        setDisabled: function (elem, value) {
            elem._select.disabled = value;
        },

        setIndex: function (elem, index) {
            elem._select.selectedIndex = index;
        }
    },

    switch: {
        init: function (elem, checked) {
            elem._switch = mdc.switchControl.MDCSwitch.attachTo(elem);
            elem._switch.checked = checked;
        },

        setChecked: function (elem, checked) {
            elem._switch.checked = checked;
        },

        setDisabled: function (elem, disabled) {
            elem._switch.disabled = disabled;
        }
    },

    tabBar: {
        init: function (elem, dotNetObject) {
            elem._tabBar = mdc.tabBar.MDCTabBar.attachTo(elem);

            return new Promise(() => {
                elem._callback = () => {
                    let index = elem._tabBar.foundation.adapter.getFocusedTabIndex();
                    dotNetObject.invokeMethodAsync('NotifyActivatedAsync', index);
                };

                elem._tabBar.listen('MDCTabBar:activated', elem._callback);
            });
        },

        activateTab: function (elem, index) {
            elem._tabBar.unlisten('MDCTabBar:activated', elem._callback);
            elem._tabBar.activateTab(index);
            elem._tabBar.listen('MDCTabBar:activated', elem._callback);
        }
    }

};