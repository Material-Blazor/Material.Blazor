---
uid: C.MBDialog
title: MBDialog
---
# MBDialog

## Summary

A [Material Dialog](https://github.com/material-components/material-components-web/tree/v9.0.0/packages/mdc-dialog#dialogs) using a render fragment for content. It features:

## Details

- A string Title;
- A render fragment custom header (N.B. Use of this RenderFragment is an extension to the strict Material theme dialog. If you want a 'pure' Material dialog don't use this parameter. Use of this render fragment moves the MBDialog into the 'Plus' category of components);
- A render fragment body;
- A render fragment for buttons, each of which should have a dialog action string which is returned by the MBDialog when the button is pressed, closing the dialog;
- Action text for when the scrim is clicked or the Escape button pressed - setting these to empty strings disables the relevant action forcing the user to close the dialog with a button press;
- An optional helper boolean to set the dialog overflow CSS attribute to "visible".

## Reserved Attributes

The following attributes are reserved by Material Components Web and will be ignored if you supply them:

- aria-describedby
- aria-labelledby
- aria-modal

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBDialog&color=brightgreen)](xref:Material.Blazor.MBDialog)
