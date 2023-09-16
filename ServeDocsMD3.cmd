@echo on
if exist api rd api /s /q
if exist SiteDocFxMD3 rd SiteDocFxMD3 /s /q
copy Material.Blazor.MD3\docfx.json.MD3 docfx.json
copy Material.Blazor.MD3\index.md.MD3 index.md
copy Material.Blazor.MD3\toc.yml.MD3 toc.yml
rem dotnet tool update -g docfx
dotnet build Material.Blazor.MD3/Material.Blazor.MD3.csproj --configuration Server
docfx docfx.json --serve
if exist api rd api /s /q
if exist SiteDocFxMD3 rd SiteDocFxMD3 /s /q
del docfx.json
del index.md
del toc.yml
