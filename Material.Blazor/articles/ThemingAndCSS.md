---
uid: A.ThemingAndCSS
title: ThemingAndCSS
---
# Theming and CSS

## Summary

Material.Blazor is concerned with components, not how to theme - that is left to you as the app developer. However we provide a little help along the way.

## Themes

One of Material Theme's big plus points is, well, theming. We have demonstrated how Material.Blazor works well with standard theming as Material Theme intends by providing four themes for 
you to select from on the [website](https://material-blazor.com) using the icon button to the right of the top app bar[<sup>1</sup>](#fn1). These themes are not suggestions for what an app
ought to look like, they just show some of what is possible with colors, fonts and border radiuses.

There are two ways to do theming that you can read about at [material.io](https://material.io/develop/web/theming/color):

- CSS variables are very simple to use, e.g. setting `--mdc-theme-primary` for the primary color. While the simplicity is great, we found the result a bit inadequate. This is because Material Theme is supported by comples SASS, and these CSS helper variables can only make best effort to achieve something similar. For instance if you set the primary color with CSS, text field labels don't change color accordingly.
- SASS mixins are harder to use, but give a fantastic result - this is what we did on the website. You need familiarity with node, SASS compilation with [Dart Sass](https://sass-lang.com/dart-sass) ([LibSass](https://sass-lang.com/libsass) won't work because it doesn't support the `@use` statement) and how to use Dart Sass from MS Build. Fortunately we managed to work some of this out for the website and you can copy what we did:
- Look at these files to understand the build process:
	- [Material.Blazor.Website.csproj](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website/Material.Blazor.Website.csproj)
	- [package.json](https://github.com/Material-Blazor/Material.Blazor/blob/main/Material.Blazor.Website/package.json)
	- Review the `.scss` files
		- in particular note that as of Material Components Web v12.0.0 we constructed our own `material-components-web.scss` file
		- this differs from what node downloads due to evolving components (e.g. lists and chips)
		- you should consider copying this file to your project to ensure correct markup

## CSS Color Helpers

There are `.scss` files spread among the components in the [Material.Blazor project](https://github.com/Material-Blazor/Material.Blazor/tree/main/Material.Blazor) that may help you. The principal
thing we want you to know of is that we have built CSS variables for the entire Material color palette which you can view on the [Material Color Tool](https://material.io/resources/color/#!/?view.left=0&view.right=0) and which are defined in the [Material Components Web theme package](https://github.com/material-components/material-components-web/blob/v9.0.0/packages/mdc-theme/_color-palette.scss).

We built a CSS variable both for each color in the palette and for the text color (light or dark) recommended to be used when the palette color is applied as a background.

- These are demonstrated on the [website's paged data list page](https://material-blazor.com/pageddatalist/).
- Our naming convention is identical to that used by Material Components Web for color SASS variables.
	- Google have chosen the British spelling for the color "grey".
	- Composite color names like "Deep Purple" use a hypen between the words in the variable name such as "deep-purple", again mirroring the Material Components Web SASS variable names.
	- The naming convention is `--mb-color-<color-name>-<color-depth>`, e.g.
		- `--mb-color-pink-50`
		- `--mb-color-deep-purple-900`
		- `--mb-color-indigo-a400`
	- The variable for the text color on a palette color background is `--mb-color-on-<color-name>-<color-depth>`, e.g.
		- `--mb-color-on-pink-50`
		- `--mb-color-on-deep-purple-900`
		- `--mb-color-on-indigo-a400`

<br />

**1<a name="fn1"></a>**: Sorry for excessively using the word "theme".