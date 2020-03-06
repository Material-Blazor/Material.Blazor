# BlazorMdc

## Lightweight Material Theme razor components for Blazor.

BlazorMdc is intended to be lightweight and rigorously faithful to the design philosophy behind [Material Theme's](https://material.io/) [web development platform](https://material.io/develop/web/). Material Theme has very specific and detailed guidance showing web designers how to build web apps with HTML, CSS and JavaScript. Since neither Blazor for WebAssembly are directly supported, Blazor developers either need to roll their own components or use a component library such as BlazorMdc. 

BlazorMdc isn't the only Blazor component library for Material Theme and we encourage developers to look at others including open source projects such as [MatBlazor](https://www.matblazor.com/), [Blazorize](https://materialdemo.blazorise.com/) and [Skclusive.Material.Component](https://github.com/skclusive/Skclusive.Material.Component), or commercial products such as those from Telerik and Syncfusion; this is not an exhaustive list and there may be others. So why create BlazorMdc as yet another option? In building our Blazor applications using Material Theme we had some overriding objectives and to our taste this required a new library focussing on the following:

- Lightweight components that require the minimal possible setup and boilerplate Blazor coding and without intensive startup processing,
- Native Blazor code to the greatest possible extent, using JavaScript Interop only where absolutely necessary, such as when initializing individual components to apply things like ripple and drop down menu functionality from the Material JavaScript libraries in the same manner as required for any other Material Theme web application,
- A balanced approach (or at least what we think is balanced) to component customization: enough to be functional but keeping things to the point and maintainable,
- A native Material Theme HTML/CSS experience where a developer wants and expects to use Material Theme's HTML Markup and CSS - BlazorMdc keeps out of a developer's way when she wants to follow Material Theme's guidance rigorously and take full advantage of its theming capability. So if you are less interested in that control but want to deliver something that looks good fast, this is where you should consider other libraries.

Please note that BlazorMdc is in the early stages of development.

## Attribution

BlazorMdc is forked from [Steve Sanderson's](https://blog.stevensanderson.com/) experimental [RazorComponents.MaterialDesign](https://github.com/SteveSandersonMS/RazorComponents.MaterialDesign) experiment. That project struck the balance we sought of giving easy to use, performant Blazor components in a lightweight, native Material Theme setting. At the present time we have revisited only a limited selection of components from RazorComponents.MaterialDesign - we are still under development.

## Demonstration website

_In the future!_
