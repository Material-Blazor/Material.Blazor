/*!
 * Sanitize and encode all HTML in a user-submitted string
 * (c) 2018 Chris Ferdinandi, MIT License, https://gomakethings.com
 * @param  {String} str  The user-submitted string
 * @return {String} str  The sanitized string
 */
var sanitizeHTMLWithBreaks = function (str) {
    let tempDiv = document.createElement('div');
    tempDiv.textContent = str;
    let sanitized = tempDiv.innerHTML;
    tempDiv.remove();
    return sanitized.replaceAll("&lt;br /&gt;", "<br />");
};

window.material_blazor = {
    autoComplete: {
        init: function (textElem, menuElem, dotNetObject) {
            textElem._textField = mdc.textField.MDCTextField.attachTo(textElem);
            menuElem._menu = mdc.menu.MDCMenu.attachTo(menuElem);
            //menuElem._menuSurface = mdc.menuSurface.MDCMenuSurface.attachTo(menuElem);

            return new Promise(() => {
                menuElem._menu.foundation.handleItemAction = listItem => {
                    menuElem._menu.open = false;
                    dotNetObject.invokeMethodAsync('NotifySelectedAsync', listItem.innerText);
                };

                menuElem._menu.foundation.adapter.handleMenuSurfaceOpened = () => {
                    menuElem._menu.foundation.setDefaultFocusState(0);
                };

                closedCallback = () => {
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };

                menuElem._menu.listen('MDCMenuSurface:closed', closedCallback);
            });
        },

        open: function (menuElem) {
            menuElem._menu.open = true;
            menuElem._menu.foundation.setDefaultFocusState(0);
        },

        close: function (menuElem) {
            menuElem._menu.open = false;
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
        init: function (elem, formFieldElem, checked, indeterminate) {
            elem._checkbox = mdc.checkbox.MDCCheckbox.attachTo(elem);
            elem._checkbox.checked = checked;
            elem._checkbox.indeterminate = indeterminate;  

            elem._formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
            elem._formField.input = elem._checkbox;
        },

        setChecked: function (elem, checked) {
            elem._checkbox.checked = checked;
        },

        setIndeterminate: function (elem, indeterminate) {
            elem._checkbox.indeterminate = indeterminate;
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
            var element = document.getElementById(id);
            element.scrollIntoView({ behavior: 'smooth', block: 'center', inline: 'start' });
        }
    },

    dataTable: {
        init: function (elem) {
            //This will only become necessary once Material.Blazor allows row selection, see: https://material.io/develop/web/components/data-tables
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
            elem._iconButtonToggle.root.click();
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
    },

    textField: {
        init: function (elem, helperTextElem, helperText, helperTextPersistent, performsValidation) {
            elem._textField = mdc.textField.MDCTextField.attachTo(elem);
            this.setHelperText(elem, helperTextElem, helperText, helperTextPersistent, performsValidation, false, "");
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
        },

        setHelperText: function (elem, helperTextElem, helperText, helperTextPersistent, performsValidation, shakeLabel, validationMessage) {
            if (helperText !== "" || performsValidation === true) {
                if (!elem._helperText) {
                    elem._helperText = mdc.textField.MDCTextFieldHelperText.attachTo(helperTextElem);
                }

                if (validationMessage !== "") {
                    elem._helperText.root.innerHTML = sanitizeHTMLWithBreaks(validationMessage);
                    elem._helperText.foundation.setPersistent(true);
                    elem._helperText.foundation.setValidation(true);
                    elem._helperText.foundation.setValidity(false);
                    elem._textField.foundation.setValid(false);

                    if (shakeLabel) {
                        elem._textField.foundation.adapter.shakeLabel(true);
                    }
                }
                else if (helperText !== "") {
                    elem._helperText.foundation.setContent(helperText);
                    elem._helperText.foundation.setPersistent(helperTextPersistent);
                    elem._helperText.foundation.setValidation(false);
                    elem._helperText.foundation.setValidity(true);
                    elem._textField.foundation.setValid(true);
                }
                else {
                    elem._helperText.foundation.setContent("");
                    elem._helperText.foundation.setPersistent(false);
                    elem._helperText.foundation.setValidation(false);
                    elem._helperText.foundation.setValidity(true);
                    elem._textField.foundation.setValid(true);
                }
            }
        },

        setType: function (inputElem, value) {
            inputElem.setAttribute("type", value);
        },
    },

    tooltip: {
        init: function (elems) {
            elems
                .filter(f => f.__internalId !== null)
                .forEach(i => mdc.tooltip.MDCTooltip.attachTo(i));
        }
    },

    topAppBar: {
        init: function (elem, scrollTarget) {
            const topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(elem);
            if (scrollTarget) {
                topAppBar.setScrollTarget(document.querySelector(scrollTarget));
            }
        }
    }
};