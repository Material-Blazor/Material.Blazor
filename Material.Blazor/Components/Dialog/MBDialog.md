---
uid: C.MBDialog
title: MBDialog
---
# MBDialog

## Summary

A [Material Dialog](https://github.com/material-components/material-components-web/tree/v7.0.0/packages/mdc-dialog#dialogs) using a render fragment for content. It features:

## Details

- A string Title;
- A render fragment body;
- A render fragment for buttons, each of which should have a dialog action string which is returned by the MBDialog when the button is pressed, closing the dialog;
- Action text for when the scrim is clicked or the Escape button pressed - setting these to empty strings disables the relevant action forcing the user to close the dialog with a button press;
- An optional helper boolean to set the dialog overflow CSS attribute to "visible".

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBDialog&color=brightgreen)](xref:BlazorMdc.MBDialog)