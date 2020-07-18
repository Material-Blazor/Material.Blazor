---
uid: A.Services
title: Services
---
## Services

Blazor MDC has services for both Toast notifications and an animated page navigation manager. These services and their functionality are optional.

### Services List

| Service | Notes |
| :------ | :---- |
| [`IMTAnimatedNavigationManager`](xref:S.IMTAnimatedNavigationManager) | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. Requires a [`MTAnimatedNavigation`](xref:C.MTAnimatedNavigation) component. This is purely optional and you can continue to use Blazor's navigtion if you don't want animation. |
| [`IIMToastService`](xref:S.IMTToastService) | Manages toast notification. Requires a [`MTToastAnchor`](xref:C.MTToastAnchor) component and will throw an exception when you attempt to show a toast notification if this isn't found. |
