@echo on
rem
rem the following two commands are for reference and are not executed as part of servedocs.cmd
rem dotnet tool install -g docfx --version "3.0.0-*" --add-source https://docfx.pkgs.visualstudio.com/docfx/_packaging/docs-public-packages/nuget/v3/index.json
rem dotnet tool update -g docfx --version "3.0.0-*" --add-source https://docfx.pkgs.visualstudio.com/docfx/_packaging/docs-public-packages/nuget/v3/index.json
rem rd api /s /q
rem rd siteDocFx /s /q
rem docfx restore
rem docfx build
rem docfx serve siteDocFx
rd api /s /q
rd siteDocFx /s /q
docfx\docfx.exe docfx.json --serve
