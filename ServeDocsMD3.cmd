@echo off
rem
rem the following two commands are for reference and are not executed as part of servedocs.cmd
rem dotnet tool install -g docfx --version "3.0.0-*" --add-source https://docfx.pkgs.visualstudio.com/docfx/_packaging/docs-public-packages/nuget/v3/index.json
rem dotnet tool update -g docfx --version "3.0.0-*" --add-source https://docfx.pkgs.visualstudio.com/docfx/_packaging/docs-public-packages/nuget/v3/index.json
rem docfx restore
rem docfx build
rem docfx serve siteDocFx
@echo on
for /d /r . %%d in (bin,obj,ClientBin,api,apiMD3,siteDocFx,siteDocFxMD3) do @if exist "%%d" rd /s /q "%%d"
copy tocMD3.yml toc.yml /Y
docfx\docfx.exe docfxMD3.json --serve
