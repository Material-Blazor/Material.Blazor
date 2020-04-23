window.BlazorMdc = {
    autoComplete: {
        init: function (textElem) {
            const text = mdc.textField.MDCTextField.attachTo(textElem);
            textElem._text = text;
        },

        open: function (menuElem, dotNetObject) {
            menuElem._menu = menuElem._menu || mdc.menu.MDCMenu.attachTo(menuElem);
            menuElem._menu.foundation_.setDefaultFocusState(0);

            return new Promise(resolve => {
                const menu = menuElem._menu;

                const openedCallback = event => {
                    menu.unlisten('MDCMenuSurface:opened', openedCallback);
                    menu.foundation_.setDefaultFocusState(1);
                    resolve(event.detail.action);
                };

                const closedCallback = event => {
                    menu.unlisten('MDCMenuSurface:closed', closedCallback);
                    resolve(event.detail.action);
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };

                menu.listen('MDCMenuSurface:opened', openedCallback);
                menu.listen('MDCMenuSurface:closed', closedCallback);
                menu.open = true;
            });
        },

        close: function (menuElem) {
            if (menuElem._menu) {
                menuElem._menu.open = false;
            }
        }
    },

    button: {
        init: function (elem) {
            mdc.ripple.MDCRipple.attachTo(elem);
        }
    },

    cardPrimaryAction: {
        init: function (elem) {
            mdc.ripple.MDCRipple.attachTo(elem);
        }
    },

    checkBox: {
        setChecked: function (elem, formFieldElem, isChecked, isFormField) {
            const checkbox = mdc.checkbox.MDCCheckbox.attachTo(elem);
            checkbox.checked = isChecked;

            if (isFormField) {
                const formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
                formField.input = checkbox;
            }
        }
    },

    dataTable: {
        init: function (elem) {
            //mdc.dataTable.MDCDataTable.attachTo(elem);
        }
    },

    datePicker: {
        init: function (elem) {
            mdc.select.MDCSelect.attachTo(elem);
        },

        listItemClick: function (elem, elemText) {
            elem.innerText = elemText;
            elem.click();
        }
    },

    dialog: {
        show: function (elem, dotNetObject, escapeKeyAction, scrimClickAction) {
            elem._dialog = elem._dialog || mdc.dialog.MDCDialog.attachTo(elem);
            elem._dotNetObject = dotNetObject;

            return new Promise(resolve => {
                const dialog = elem._dialog;

                const openedCallback = event => {
                    dialog.unlisten('MDCDialog:opened', openedCallback);
                    dotNetObject.invokeMethodAsync('NotifyOpenedAsync');
                };

                const closingCallback = event => {
                    dialog.unlisten('MDCDialog:closing', closingCallback);
                    resolve(event.detail.action);
                };

                dialog.listen('MDCDialog:opened', openedCallback);
                dialog.listen('MDCDialog:closing', closingCallback);
                dialog.escapeKeyAction = escapeKeyAction;
                dialog.scrimClickAction = scrimClickAction;
                dialog.open();
            });
        },

        hide: function (elem, dialogAction) {
            if (elem._dialog) {
                elem._dialog.close(dialogAction || 'dismissed');
            }
        },

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
        init: function (elem, dotNetObject) {
            elem._iconToggleButton = mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
            elem._dotNetObject = dotNetObject;

            return new Promise(resolve => {
                const callback = event => {
                    resolve(event.detail.action);
                    elem._dotNetObject.invokeMethodAsync('NotifyOnAsync', elem._iconToggleButton.on);
                };

                elem._iconToggleButton.listen('MDCIconButtonToggle:change', callback);
            });
        },

        turnOn: function (elem) {
            if (elem) {
                if (elem._iconToggleButton.on != true) {
                    elem.click();
                }
            }
        },

        turnOff: function (elem) {
            if (elem) {
                if (elem._iconToggleButton.on == true) {
                    elem.click();
                }
            }
        }
    },

    list: {
        init: function (elem, keyboardInteractions, ripple) {
            if (keyboardInteractions == true) {
                const list = mdc.list.MDCList.attachTo(elem);

                if (ripple == true) {
                    list.listElements.map((elem) => mdc.ripple.MDCRipple.attachTo(elem));
                }
            }
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

    radioButton: {
        init: function (elem, formFieldElem, isChecked) {
            let radio = mdc.radio.MDCRadio.attachTo(elem);
            radio.checked = isChecked;
            let formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
            formField.input = radio;
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
        },

        select: function (elem) {
            for (i = 0; i < elem.children.length; i++) {
                if (elem.children[i].tagName == "INPUT") {
                    let input = elem.children[i];
                    input.focus();
                    input.select();
                }
            }
        }
    },

    tabBar: {
        init: function (elem) {
            elem._tabBar = mdc.tabBar.MDCTabBar.attachTo(elem);
        },

        setTab: function (elem, index) {
            if (elem._tabBar) {
                let tl = elem._tabBar.tabList_[index];
                tl.root_.click();
            }
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
