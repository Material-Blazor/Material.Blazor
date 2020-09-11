---
uid: A.AnimatedNavigation
title: AnimatedNavigation
---
# Animated Navigation

## Summary

The animated navigation manager is an optional service that adds a simple fade out/fade in animation to page navigation. The service
itself consumes the `INavigationManager` service to achieve this, and exposes it's reference to that service. To use animated navigations,
surround your `@Body` renderfragment in `MainLayout.razor` with the [MBAnimatedNavigation](xref:C.MBAnimatedNavigation) component.

While calling `services.AddMBServices( ... );` will add the animated navigation manager service, you do not need to use it and can continue
to navigate with the `INavigationManager` service if you prefer. If you do use animated navigation, you can configure the animation time in milliseconds
and whether to animate in the service configuration as described in the [Installation](xref:A.Installation) article.

## Using the MBAnimatedNavigation Component

Surround @Body with the component thus:

```html
<MBAnimatedNavigation>
    @Body
</MBAnimatedNavigation>
```

The Blazor MDC website uses the following code to animate everything except for the top app bar and drawer:

```html
<MBAnimatedNavigation>
    <div class="mdc-top-app-bar--dense-fixed-adjust">
        <div class="main-content">
            <div class="mdc-layout-grid">
                <div class="mdc-layout-grid__inner">
                    @Body
                </div>
            </div>
        </div>
    </div>
</MBAnimatedNavigation>
```