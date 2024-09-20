@echo on
if exist ".artifact\api" rd ".artifacts\api" /s /q
if exist ".artifacts\SiteDocFx" rd ".artifacts\SiteDocFx" /s /q
rem dotnet tool update -g docfx
dotnet build Material.Blazor/Material.Blazor.csproj --configuration Server
docfx docfx.json --serve
