@echo on
rem dotnet tool install -g docfx --version "3.0.0-*" --add-source https://docfx.pkgs.visualstudio.com/docfx/_packaging/docs-public-packages/nuget/v3/index.json
rem docfx build 
rem docfx serve siteDocFx
rmdir /s /q api
rmdir /s /q siteDocFx
docfx\docfx.exe .\docfx.json --serve
