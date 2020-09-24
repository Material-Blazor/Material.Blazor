---
uid: A.Demonstration
title: Demonstration
---
# Demonstration website

We are not yet hosting a demonstration, but you can fork and download this project yourself. If you so so, set your default project to `BlazorMdc.Demo.WebServer`.

## Demonstration from local build

If you have cloned the repository and are building from source there is a project 'BlazorMDC.Demo.WebServer' that should be selected as the startup project.
 
Note that we compile, bundle and minify SASS/CSS and JS. In Visual Studio you will need to install the [Bundler Minifier](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.BundlerMinifier) and [Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler) extensions.

If you are experimenting with different versions of the Material Design Components you will need to build the BlazorMDC.MaterialComponents project. You need to install `libman` if you haven't already:
```console
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

There are four implemented solution configurations:

| Configuration | Notes |
| :------------ | :---- |
| `Debug_WebAssembly` | This is a debug build. It defines two constants, DEBUG, and BlazorWebAssembly. It executes using WebAssembly. |
| `Debug_Server` | Also a debug build, defines DEBUG and BlazorServer. It executes in the context of the web server and the the client being displayed through a SignalR connection. |
| `Release_WebAssembly` | The same as `Debug_WebAssembly` but built as release and replacing the DEBUG constant with RELEASE. |
| `Release_Server` | The same as `Debug_Server` but built as release and replacing the DEBUG constant with RELEASE. |

The home page of the demonstration application shows the execution environment as well as the build mode.