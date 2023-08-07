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

## Namespaces

Material.Blazor has two namespaces:

- `Material.Blazor` is the only namespace that you should use. You can add `@using Material.Blazor` to your project's _Imports.razor file.
- There is also a `Material.Blazor.Internal` namespace that you should not use. We use this namespace for some components that are intended only for internal use in Material.Blazor, however Blazor has no mechanism to restrict components to internal usage (mirroring the C# "internal" directive).
