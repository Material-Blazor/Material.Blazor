@echo on
if exist api rd api /s /q
if exist SiteDocFx rd SiteDocFx /s /q
copy Material.Blazor\docfx.json.MD2 docfx.json /Y
copy Material.Blazor\index.md.MD2 index.md /Y
copy Material.Blazor\toc.yml.MD2 toc.yml /Y
rem dotnet tool update -g docfx
dotnet build Material.Blazor/Material.Blazor.csproj --configuration Server
docfx docfx.json --serve
if exist api rd api /s /q
if exist SiteDocFx rd SiteDocFx /s /q
del docfx.json
del index.md
del toc.yml
