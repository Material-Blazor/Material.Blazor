---
uid: A.Principles
title: Principles
---
# Principles behind Material.Blazor

We built Material.Blazor with the following principles in mind:

- Permissive [MIT license](xref:A.License) and a clear [contributor code of conduct](xref:A.CodeOfConduct);
- Lightweight components that require the minimal possible setup or boilerplate Blazor coding and without intensive startup processing,
- An entirely native Blazor experience for Material.Blazor's consumer, using JavaScript Interop within Material.Blazor only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS. Material.Blazor keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. This requires you to manage your layout because Material.Blazor does not attempt to give you layout shortcuts. This is so you can decide what layout system to use? Material Theme, Bootstrap or as you wish. Other libraries take a different approach, and if you have a different requirement you may want to consider other options,
- Some added value components derived from core material theme components but that are not strictly material theme themselves. These include an autocomplete box, a confimration dialog and formatted numeric input fields. We also provide a date picker and paginator, each of which follow Material Theme specification in the absence of a Material Theme css/js implementation, and
- We aim for Material.Blazor to employ best practice for Blazor development. As a starting point this should be considered as being defined per [this video from NDC London, January 2020](https://www.youtube.com/watch?v=QnBYmTpugz0).

## Managing interaction between Blazor and Material Theme JS

Blazor does not have access to the DOM and updates components by re-rendering them. Material Theme on the other hand, as a comprehensive JavaScript library, updates components by directly changing
DOM elements once components have been registered with Material Theme. These differing approaches cause conflicts if not properly managed, severely degrading the user experience. Imagine for example
the following situation:

- A Blazor component library creates a Material Theme Select component and initializes it making a JSInterop call `mdc.select.MDCSelect.attachTo(selectElem)`;
- The user then makes selection changes, which updates the DOM;
- The Blazor component then decides to change the selected value, re-rendering the select's markup;
- The markup displayed on the app page now differs from the Material Theme framework's record of what markup should be displayed - the select is broken.

We have overcome this by ensuring that Material.Blazor steps out of the way of Material Theme once components have been intialized, so that Blazor no longer re-renders. In practice this means that
once initialized, the component's `ShouldRender()` lifecycle method is set to return false, disabling Blazor's ability to re-render. This then means that two-way binding of Value and Disabled
parameters needs to make appropriate JSInterop calls to update values using the Material Theme javascript framework. This pattern is handled in the Material.Blazor's internal `InputComponentFoundation`
abstract class.

This is an unusual approach for a Blazor component library, but it is the key methodology that makes Material Theme components behave precisely as they should. Material.Blazor then does the hard work
of encapsulating this and transforming it into a native blazor experience for the libary's consumer.

## Component Intialization

All Material Theme components need to make intiialization calls to the Material Theme JavaScript libraries. There is a special case where this needs to be delayed: dialogs (see [MB documentation](https://material.io/develop/web/components/dialogs)).
Some components need either to be initialized after a dialog has opened (with its transition), or to be re laid out. Material.Blazor takes an approach where every component can detect whether it is in a dialog.
If so, it does one of two things:

1. If the dialog has not been opened, rather than initializing after the component's first render, it registers a callback with the dialog, so the dialog can initialize it after opening; or
1. If the dialog is already open, the component intializes immediately after it has first rendered.

This mechanism is also handled in the Material.Blazor's internal `InputComponentFoundation` abstract class.

## Namespaces

Material.Blazor has two namespaces:

- `Material.Blazor` is the only namespace that you should use. You can add `@using Material.Blazor` to your project's _Imports.razor file.
- There is also a `Material.Blazor.Internal` namespace that you should not use. We use this namespace for some components that are intended only for internal use in Material.Blazor, however Blazor has no mechanism to restrict components to internal usage (mirroring the C# "internal" directive).
