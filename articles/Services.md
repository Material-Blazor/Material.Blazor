---
uid: A.Services
title: Services
---
## Services

Blazor MDC has services for both Toast notifications and an animated page navigation manager. These services and their functionality are optional.

### Services List

| Service | Notes |
| :------ | :---- |
| [`IMTAnimatedNavigationManager`](~/BlazorMdc/Components/AnimatedNavigationManager/IMTAnimatedNavigationManager.razor.html) | Manages fade out/in page navigation, wrapping Blazor's `NavigationManager.NavigateTo()` function. Requires a [`MTAnimatedNavigation`](~/BlazorMdc/Components/AnimatedNavigation/MTAnimatedNavigation.razor.html) component. This is purely optional and you can continue to use Blazor's navigtion if you don't want animation. |
| [`IIMToastService`](~/BlazorMdc/Components/ToastService/IMTToastService.razor.html) | Manages toast notification. Requires a [`MTToastAnchor`](~/BlazorMdc/Components/ToastAnchor/MTToastAnchor.razor.html) component and will throw an exception when you attempt to show a toast notification if this isn't found. |
