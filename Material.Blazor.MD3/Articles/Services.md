---
uid: A.Services
title: Services
---
# Services

Material.Blazor has services for snackbar, toast notifications, and tooltips. These services and their functionality are optional.

## Services List

| Service | Notes |
| :------ | :---- |
| [IMBToastService](xref:S.IMBToastService) | Manages toast notification. Requires an [MBAnchor](xref:C.MBAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |
