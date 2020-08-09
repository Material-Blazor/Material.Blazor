---
uid: U.MTIconHelper
title: MTIconHelper
---
# MTIconHelper

### Summary

A helper class returning icon foundries for icons in use across Blazor MDC components.

### Details

- Has [three static methods (click for API documentation)](xref:BlazorMdc.MTIconHelper#methods) to return one of the following three icon foundries for any `IconFoundry` component parameter:
  - Material Icons via `MTIconHelper.MIFoundry(Nullable<MTIconMITheme>)`;
  - Font Awesome Icons via `MTIconHelper.FAFoundry(Nullable<MTIconFAStyle>, Nullable<MTIconFARelativeSize>)`; and
  - Open Iconic Icons via `MTIconHelper.OIFoundry()`;
- Material Icons are included in the Blazor MDC bundled CSS;
- [Font Awesome Icons version 5](https://fontawesome.com/changelog/latest) are optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css" integrity="sha512-1PKOgIY59xJ8Co8+NE6FZ+LOAZKjy+KY8iq0G4B3CyeY6wYHN3yt9PW0XpSriVlkMXe40PTKnXrLnZ9+fkDaog==" crossorigin="anonymous" />
    ```
- [Open Iconic Icons version 1.1](https://useiconic.com/open) are also optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link href="https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic.min.css" crossorigin="anonymous" rel="stylesheet" />
    ```

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=See&message=Utilities&color=orange)](xref:A.Utilities)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTIconHelper&color=brightgreen)](xref:BlazorMdc.MTIconHelper)