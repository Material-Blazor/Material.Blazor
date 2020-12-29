---
uid: A.Services
title: Services
---
# Services

Material.Blazor has services for both Toast notifications and an animated page navigation manager. These services and their functionality are optional.

## Services List

| Service | Notes |
| :------ | :---- |
| [IMBAnimatedNavigationManager](xref:S.IMBAnimatedNavigationManager) | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. Requires an [MBAnimatedNavigation](xref:C.MBAnimatedNavigation) component. This is purely optional and you can continue to use Blazor's navigation if you don't want animation. |
| [IMBoastService](xref:S.IMBToastService) | Manages toast notification. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |
| [IMBooltipService](xref:S.IMBTooltipService) | Manages tooltips. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |

## Blades Aren't a Service

[MBBladeSet](xref:C.MBBladeSet) doesn't use a service to allow the consumer to add and remove blades, but instead declares itself as a cascading value for enclosed components to
access. The reason is that there's a good use case for MBBladeSet to be used on individual pages, meaning that all blades and their data should disappear when the user navigates
away. A service would be poorly suited to this requirement.

Our demonstration web app applies blades in `MainLayout.razor`, however you can use this component wherever makes sense for your app.