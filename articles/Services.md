---
uid: A.Services
title: Services
---
# Services

Blazor MDC has services for both Toast notifications and an animated page navigation manager. These services and their functionality are optional.

## Services List

| Service | Notes |
| :------ | :---- |
| [IMBAnimatedNavigationManager](xref:S.IMBAnimatedNavigationManager) | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. Requires an [MBAnimatedNavigation](xref:C.MBAnimatedNavigation) component. This is purely optional and you can continue to use Blazor's navigation if you don't want animation. |
| [IMBoastService](xref:S.IMBToastService) | Manages toast notification. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |
| [IMBooltipService](xref:S.IMBTooltipService) | Manages tooltips. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |