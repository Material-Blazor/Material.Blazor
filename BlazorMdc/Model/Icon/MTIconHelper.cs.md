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
- Font Awesome Icons (version 5) are optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link href="https://use.fontawesome.com/releases/v5.13.0/css/all.css" integrity="sha384-Bfad6CLCknfcloXFOyFnlgtENryhrpZCe29RTifKEixXQZ38WheV+i/6YWSzkz3V" crossorigin="anonymous" rel="stylesheet">
    ```
- Open Iconic Icons (version 1.1) are also optional and can be included in your HTML `<head>` with the CDN link:
    ```html
    <link href="https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic.min.css" crossorigin="anonymous" rel="stylesheet" />
    ```

&nbsp;

&nbsp;

[![Components](https://img.shields.io/static/v1?label=See&message=Utilities&color=orange)](xref:A.Utilities)
[![Docs](https://img.shields.io/static/v1?label=API%20Documentation&message=MTIconHelper&color=brightgreen)](xref:BlazorMdc.MTIconHelper)