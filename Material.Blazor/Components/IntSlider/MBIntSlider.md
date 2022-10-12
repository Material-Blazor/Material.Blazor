---
uid: C.MBIntSlider
title: MBIntSlider
---
# MBSlider

## Summary

A single thumb [Material Slider](https://github.com/material-components/material-components-web/tree/v9.0.0/packages/mdc-slider#slider) working on integers.

## Details

- Two-way binds an int Value parameter;
- Implements only discrete slider variants.
- Emits events on:
  - Thumb-up;
  - Debounced, meaning that events are emitted once the slider stops moving, but before thumb-up; or
  - Throttled, so that events are emitted continuously as the slider is moved.
- Debounce and throttle implemented in JS to avoid excessive/inefficient use of Blazor JSInterop.

- ValueMin and ValueMax are set in OnInitialized and not in SetParameters

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBIntSlider&color=brightgreen)](xref:Material.Blazor.MBIntSlider)
