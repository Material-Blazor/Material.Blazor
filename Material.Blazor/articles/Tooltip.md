---
uid: A.Tooltip
title: Tooltip
---
# Tooltip

## Summary

The Material Components Web framework will provide tooltips in the upcoming version 9.0.0. We decided to jump the gun and
have included tooltips early. Tooltips are driven by [IMBTooltipService](xref:S.IMBTooltipService) which is registered by calling
`services.AddMBServices();`, and are anchored by [MBAnchor](xref:C.MBAnchor).

## Using Toolips with Components

All Material.Blazor components have a `Tooltip` string parameter. This parameter accepts markup, so you can use `Tooltip="a tooltip"`
or `Tooltip="<span style='color: lightblue;'>a colored tooltip</span>"`.

## Standalone Tooltips

The [MBTooltip](xref:C.MBTooltip) component gives you flexible tooltips that take two renderfragments: Target to render
in your page and Content for the tooltip's content, e.g.:

```html
<MBTooltip>
    <Target>
        <span style="background-color: var(--mb-color-red-100);">This is the target span to be displayed in your razor page.</span>
    </Target>
    <Content>
        this is a <strong>span</strong> type of tooltip
    </Content>
</MBTooltip>
```
