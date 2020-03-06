window.BlazorMdc = {
    button: {
        init: function (elem) {
            mdc.ripple.MDCRipple.attachTo(elem);
        }
    },

    dialog: {
        show: function (elem) {
            elem._dialog = elem._dialog || mdc.dialog.MDCDialog.attachTo(elem);
            return new Promise(resolve => {
                const dialog = elem._dialog;
                const callback = event => {
                    dialog.unlisten('MDCDialog:closing', callback);
                    resolve(event.detail.action);
                };
                dialog.listen('MDCDialog:closing', callback);
                dialog.open();
            });
        },

        hide: function (elem, dialogAction) {
            if (elem._dialog) {
                elem._dialog.close(dialogAction || 'dismissed');
            }
        }
    },

    drawer: {
        toggle: function (elem, isOpen) {
            const drawer = mdc.drawer.MDCDrawer.attachTo(elem);
            drawer.open = isOpen;
        }
    },

    iconButton: {
        init: function (elem) {
            const iconButtonRipple = mdc.ripple.MDCRipple.attachTo(elem);
            iconButtonRipple.unbounded = true;
        }
    },

    iconButtonToggle: {
        init: function (elem) {
            mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
        }
    },

    menu: {
        show: function (elem, dotNetObject) {
            elem._menu = elem._menu || mdc.menu.MDCMenu.attachTo(elem);
            return new Promise(resolve => {
                const menu = elem._menu;
                const callback = event => {
                    menu.unlisten('MDCMenuSurface:closed', callback);
                    resolve(event.detail.action);
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };
                menu.listen('MDCMenuSurface:closed', callback);
                menu.open = true;
            });
        },

        hide: function (elem) {
            if (elem._menu) {
                elem._menu.open = false;
            }
        }
    },

    select: {
        init: function (elem) {
            mdc.select.MDCSelect.attachTo(elem);
        }
    },

    switch: {
        setChecked: function (elem, isChecked) {
            const switchControl = mdc.switchControl.MDCSwitch.attachTo(elem);
            switchControl.checked = isChecked;
        }
    },

    textField: {
        init: function (elem) {
            mdc.textField.MDCTextField.attachTo(elem);
        }
    },

    tabBar: {
        init: function (elem) {
            mdc.tabBar.MDCTabBar.attachTo(elem);
        }
    },

    topAppBar: {
        init: function (elem, scrollTarget) {
            const topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(elem);
            if (scrollTarget) {
                topAppBar.setScrollTarget(document.querySelector(scrollTarget));
            }
        }
    },
};
