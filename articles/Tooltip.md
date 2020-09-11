---
uid: A.Tooltip
title: Tooltip
---
# Tooltip

## Summary

The Material Components Web framework will provide tooltips in the upcoming version 8.0.0. We decided to jump the gun and
have included tooltips early. Tooltips are driven by [IMTTooltipService](xref:S.IMTTooltipService) which is registered by calling
`services.AddMTServices();`, and are anchored by [MTAnchor](xref:C.MTAnchor).

## Using Toolips with Components

All Blazor MDC components have a `Tooltip` string parameter. This parameter accepts markup, so you can use `Tooltip="a tooltip"`
or `Tooltip="<span style='color: lightblue;'>a colored tooltip</span>"`.

## Standalone Tooltips

The [MTTooltip](xref:C.MTTooltip) component gives you flexible tooltips that take two renderfragments: Target to render
in your page and Content for the tooltip's content, e.g.:

```html
<MTTooltip TooltipType="@MTTooltipType.Span">
    <Target>
        <span style="background-color: var(--bmdc-color-red-100);">This is the target span to be displayed in your razor page.</span>
    </Target>
    <Content>
        this is a <strong>span</strong> type of tooltip
    </Content>
</MTTooltip>
```

This tooltip surrounds your `<Target>` with either a span or div depending on whether the `TooltipType` is `MTTooltipType.Span` or
`MTTooltipType.Div` respectively.