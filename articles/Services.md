---
uid: A.Services
title: Services
---
# Services

Material.Blazor has services for snackbars and tooltips. These services and their functionality are optional.

## Services List

| Service | Notes |
| :------ | :---- |
| [IMBSnackbarService](xref:S.IMBSnackbarService) | Manages snackbar notification. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a snackbar notification if this isn't found. |
| [IMBTooltipService](xref:S.IMBTooltipService) | Manages tooltips. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a tooltip notification if this isn't found. |

## Blades Aren't a Service

[MBBladeSet](xref:C.MBBladeSet) doesn't use a service to allow the consumer to add and remove blades, but instead declares itself as a cascading value for enclosed components to
access. The reason is that there's a good use case for MBBladeSet to be used on individual pages, meaning that all blades and their data should disappear when the user navigates
away. A service would be poorly suited to this requirement.

Our demonstration web app applies blades in `MainLayout.razor`, however you can use this component wherever makes sense for your app.