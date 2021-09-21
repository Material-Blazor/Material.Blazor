---
uid: A.AnimatedNavigation
title: AnimatedNavigation
---
# Animated Navigation - DEPRECATED

## Summary

**Animated Navigation is deprecated**. We are not comfortable that it operates correctly (it shows flashes of unstyled content) and we advise you to remove it from your
project. We will not remove Animated Navigation for the duration of Material.Blazor version 2, however thereafter we may either re-implement or remove it.

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

The Material.Blazor website uses the following code to animate everything except for the top app bar and drawer:

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
## Important note about the markup consequences of using MBAnimatedNavigation

`MBAnimatedNavigation` introduces a `<div>` to your DOM. You need therefore to design your DOM accordingly. You can add `class` and `style` attributes to
`MBAnimatedNavigation`.

An example of where introduction of a `<div>` by `MBAnimatedNavigation` can cause side effects is if for instance you make it a direct child of a `<div>` that
implements `display: flex;`. Flex expects its immediate children to be aligned according the the flex rules, however there will in fact be only one child: the `MBAnimatedNavigation` itself!
The divs inside the `MBAnimatedNavigation` will then not be flex children themselves and will align vertically as a result.