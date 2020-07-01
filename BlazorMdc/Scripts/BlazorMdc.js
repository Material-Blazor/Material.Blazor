window.BlazorMdc = {
    autoComplete: {
        init: function (textElem) {
            textElem._textField = mdc.textField.MDCTextField.attachTo(textElem);
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
        },

        setValue: function (textElem, value) {
            textElem._textField.value = value;
        },

        setDisabled: function (textElem, disabled) {
            textElem._textField.disabled = disabled;
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
        init: function (elem, formFieldElem, isChecked, isFormField) {
            elem._checkbox = mdc.checkbox.MDCCheckbox.attachTo(elem);
            elem._checkbox.checked = isChecked;

            if (isFormField) {
                elem._formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
                elem._formField.input = checkbox;
            }
        },

        setChecked: function (elem, checked) {
            elem._checkbox.checked = checked;
        },

        setDisabled: function (elem, disabled) {
            elem._checkbox.disabled = disabled;
        }
    },

    circularProgress: {
        init: function (elem, progress) {
            elem._circularProgress = mdc.circularProgress.MDCCircularProgress.attachTo(elem);
            this.setProgress(elem, progress);
        },

        setProgress: function (elem, progress) {
            elem._circularProgress.progress = progress;
        }
    },

    datePicker: {
        init: function (elem) {
            elem._select = mdc.select.MDCSelect.attachTo(elem);
        },

        listItemClick: function (elem, elemText) {
            elem.innerText = elemText;
            elem.click();
        },

        scrollToYear: function (id) {
            // Presently disabled because of undesirable overscroll-behaviour
            //var element = document.getElementById(id);
            //element.scrollIntoView({ behavior: 'smooth', block: 'nearest', inline: 'start' });
            //element.scrollIntoView();
        }
    },

    dataTable: {
        init: function (elem) {
            //mdc.dataTable.MDCDataTable.attachTo(elem);
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
        init: function (elem) {
            elem._iconButtonToggle = mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
        },

        setOn: function (elem, isOn) {
            elem._iconButtonToggle.on = isOn;
        },

        click: function (elem) {
            elem._iconButtonToggle.root_.click();
        }
    },

    linearProgress: {
        init: function (elem, progress, buffer) {
            elem._linearProgress = mdc.linearProgress.MDCLinearProgress.attachTo(elem);
            this.setProgress(elem, progress, buffer);
        },

        setProgress: function (elem, progress, buffer) {
            elem._linearProgress.progress = progress;
            elem._linearProgress.buffer = buffer;
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
        init: function (elem) {
            elem._select = mdc.select.MDCSelect.attachTo(elem);
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

    textField: {
        init: function (elem) {
            elem._textField = mdc.textField.MDCTextField.attachTo(elem);
        },

        select: function (inputElem) {
            inputElem.focus();
            inputElem.select();
        },

        setValue: function (elem, value) {
            elem._textField.value = value;
        },

        setDisabled: function (elem, value) {
            elem._textField.disabled = value;
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
