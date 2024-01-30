---
uid: C.MBMenu
title: MBMenu
---
# MBMenu

## Summary

A simple collection of [MBMenuItems](https://material-web.dev/components/Menu/) used to initiate an action.
MenuItems are enclosed in a Menu container

## Reserved Attributes

The following attributes are reserved by Material Components Web and will be ignored if you supply them:

- role
- type

## Build quirk

When Material.Blazor.MD3.lib.module.js is built, it is built as a module. The file needs to be modified, removing all traces of the module system and ADDING 'export' to the function lines

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBMenu&color=brightgreen)](xref:Material.Blazor.MBMenu)
