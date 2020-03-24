window.BlazorMdc = {
    autoComplete: {
        init: function (textElem) {
            const text = mdc.textField.MDCTextField.attachTo(textElem);
            textElem._text = text;
        },

        open: function (menuElem, textElem, dotNetObject) {
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

        close: function (menuElem, textElem) {
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

    card: {
        init: function (elem) {
            const selector = '.mdc-button, .mdc-icon-button, .mdc-card__primary-action';

            //Do not know how to get this job done, so cards don't yet have ripple
            //[].map.call(document.querySelectorAll(selector), function (elem) {
            //    return new MDCRipple(elem);
            //});
            //mdc.ripple.MDCRipple.attachTo(elem);
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
        init: function (elem, dotNetObject) {
            elem._picker = mdc.select.MDCSelect.attachTo(elem);
            return new Promise(resolve => {
                const picker = elem._picker;
                const callback = event => {
                    picker.unlisten('MDCSelectAdapter:closeMenu', callback);
                    resolve(event.detail.action);
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };
                picker.listen('MDCSelectAdapter:closeMenu', callback);
                picker.open = true;
            });
        },

        listItemClick: function (elem) {
            elem.click();
        }
    },

    dialog: {
        show: function (elem, newEscapeKeyAction, newScrimClickAction) {
            elem._dialog = elem._dialog || mdc.dialog.MDCDialog.attachTo(elem);

            return new Promise(resolve => {
                const dialog = elem._dialog;

                const callback = event => {
                    dialog.unlisten('MDCDialog:closing', callback);
                    resolve(event.detail.action);
                };

                dialog.listen('MDCDialog:closing', callback);
                dialog.escapeKeyAction = newEscapeKeyAction;
                dialog.scrimClickAction = newScrimClickAction;
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
        init: function (elem) {
            mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
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

    radioButtons: {
        init: function (formFieldElem, radioButtons) {
            const formField = mdc.formField.MDCFormField.attachTo(formFieldElem);

            for (let i = 0; i < radioButtons.length; i++) {
                let radio = mdc.radio.MDCRadio.attachTo(radioButtons[i].elementReference);

                //Not sure if this is the right thing to do, so requires review
                if (radioButtons[i].checked == true) {
                    formField.input = radio;
                }
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
            elem._tabBar = mdc.tabBar.MDCTabBar.attachTo(elem);
        },

        setTab: function (elem, index) {
            if (elem._tabBar) {
                let tl = elem._tabBar.tabList_[index];
                //elem._tabBar.tabList_[index].handleClick_();
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
