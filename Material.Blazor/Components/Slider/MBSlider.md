---
uid: C.MBSlider
title: MBSlider
---
# MBSlider

## Summary

A single thumb [Material Slider](https://github.com/material-components/material-components-web/tree/v9.0.0/packages/mdc-slider#slider).

## Details

- Two-way binds a decimal Value parameter;
- Implements both continuous and discrete slider variants.
- Emits events on:
  - Thumb-up;
  - Debounced, meaning that events are emitted once the slider stops moving, but before thumb-up; or
  - Throttled, so that events are emitted continuously as the slider is moved.
- Debounce and throttle implemented in JS to avoid excessive/inefficient use of Blazor JSInterop.

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=Components&message=Core&color=blue)](xref:A.CoreComponents)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MBSlider&color=brightgreen)](xref:Material.Blazor.MBSlider)
