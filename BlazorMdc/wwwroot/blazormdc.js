'use strict';

window.BlazorMdc = {
    autoComplete: {
        init: function init(textElem) {
            var text = mdc.textField.MDCTextField.attachTo(textElem);
            textElem._text = text;
        },

        open: function open(menuElem, textElem, dotNetObject) {
            menuElem._menu = menuElem._menu || mdc.menu.MDCMenu.attachTo(menuElem);
            menuElem._menu.foundation_.setDefaultFocusState(0);

            return new Promise(function (resolve) {
                var menu = menuElem._menu;

                var openedCallback = function openedCallback(event) {
                    menu.unlisten('MDCMenuSurface:opened', openedCallback);
                    menu.foundation_.setDefaultFocusState(1);
                    resolve(event.detail.action);
                };

                var closedCallback = function closedCallback(event) {
                    menu.unlisten('MDCMenuSurface:closed', closedCallback);
                    resolve(event.detail.action);
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };

                menu.listen('MDCMenuSurface:opened', openedCallback);
                menu.listen('MDCMenuSurface:closed', closedCallback);
                menu.open = true;
            });
        },

        close: function close(menuElem, textElem) {
            if (menuElem._menu) {
                menuElem._menu.open = false;
            }
        }
    },

    button: {
        init: function init(elem) {
            mdc.ripple.MDCRipple.attachTo(elem);
        }
    },

    cardPrimaryAction: {
        init: function init(elem) {
            mdc.ripple.MDCRipple.attachTo(elem);
        }
    },

    checkBox: {
        setChecked: function setChecked(elem, formFieldElem, isChecked, isFormField) {
            var checkbox = mdc.checkbox.MDCCheckbox.attachTo(elem);
            checkbox.checked = isChecked;

            if (isFormField) {
                var formField = mdc.formField.MDCFormField.attachTo(formFieldElem);
                formField.input = checkbox;
            }
        }
    },

    dataTable: {
        init: function init(elem) {
            //mdc.dataTable.MDCDataTable.attachTo(elem);
        }
    },

    datePicker: {
        init: function init(elem) {
            mdc.select.MDCSelect.attachTo(elem);
        },

        listItemClick: function listItemClick(elem, elemText) {
            elem.innerText = elemText;
            elem.click();
        }
    },

    dialog: {
        show: function show(elem, dotNetObject, escapeKeyAction, scrimClickAction) {
            elem._dialog = elem._dialog || mdc.dialog.MDCDialog.attachTo(elem);
            elem._dotNetObject = dotNetObject;

            return new Promise(function (resolve) {
                var dialog = elem._dialog;

                var openedCallback = function openedCallback(event) {
                    dialog.unlisten('MDCDialog:opened', openedCallback);
                    dotNetObject.invokeMethodAsync('NotifyOpenedAsync');
                };

                var closingCallback = function closingCallback(event) {
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

        hide: function hide(elem, dialogAction) {
            if (elem._dialog) {
                elem._dialog.close(dialogAction || 'dismissed');
            }
        }

    },

    drawer: {
        toggle: function toggle(elem, isOpen) {
            var drawer = mdc.drawer.MDCDrawer.attachTo(elem);
            drawer.open = isOpen;
        }
    },

    iconButton: {
        init: function init(elem) {
            var iconButtonRipple = mdc.ripple.MDCRipple.attachTo(elem);
            iconButtonRipple.unbounded = true;
        }
    },

    iconButtonToggle: {
        init: function init(elem) {
            mdc.iconButton.MDCIconButtonToggle.attachTo(elem);
        }
    },

    list: {
        init: function init(elem, keyboardInteractions, ripple) {
            if (keyboardInteractions == true) {
                var list = mdc.list.MDCList.attachTo(elem);

                if (ripple == true) {
                    list.listElements.map(function (elem) {
                        return mdc.ripple.MDCRipple.attachTo(elem);
                    });
                }
            }
        }
    },

    menu: {
        show: function show(elem, dotNetObject) {
            elem._menu = elem._menu || mdc.menu.MDCMenu.attachTo(elem);
            return new Promise(function (resolve) {
                var menu = elem._menu;
                var callback = function callback(event) {
                    menu.unlisten('MDCMenuSurface:closed', callback);
                    resolve(event.detail.action);
                    dotNetObject.invokeMethodAsync('NotifyClosedAsync');
                };
                menu.listen('MDCMenuSurface:closed', callback);
                menu.open = true;
            });
        },

        hide: function hide(elem) {
            if (elem._menu) {
                elem._menu.open = false;
            }
        }
    },

    radioButtons: {
        init: function init(formFieldElem, radioButtons) {
            var formField = mdc.formField.MDCFormField.attachTo(formFieldElem);

            for (var _i = 0; _i < radioButtons.length; _i++) {
                var radio = mdc.radio.MDCRadio.attachTo(radioButtons[_i].elementReference);

                //Not sure if this is the right thing to do, so requires review
                if (radioButtons[_i].checked == true) {
                    formField.input = radio;
                }
            }
        }
    },

    select: {
        init: function init(elem) {
            mdc.select.MDCSelect.attachTo(elem);
        }
    },

    'switch': {
        setChecked: function setChecked(elem, isChecked) {
            var switchControl = mdc.switchControl.MDCSwitch.attachTo(elem);
            switchControl.checked = isChecked;
        }
    },

    textField: {
        init: function init(elem) {
            mdc.textField.MDCTextField.attachTo(elem);
        },

        select: function select(elem) {
            for (i = 0; i < elem.children.length; i++) {
                if (elem.children[i].tagName == "INPUT") {
                    var input = elem.children[i];
                    input.focus();
                    input.select();
                }
            }
        }
    },

    tabBar: {
        init: function init(elem) {
            elem._tabBar = mdc.tabBar.MDCTabBar.attachTo(elem);
        },

        setTab: function setTab(elem, index) {
            if (elem._tabBar) {
                var tl = elem._tabBar.tabList_[index];
                tl.root_.click();
            }
        }
    },

    topAppBar: {
        init: function init(elem, scrollTarget) {
            var topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(elem);
            if (scrollTarget) {
                topAppBar.setScrollTarget(document.querySelector(scrollTarget));
            }
        }
    }
};

