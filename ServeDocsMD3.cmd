@echo on
rd /s /q SiteDocFxMD3
md Articles
copy Material.Blazor.MD3\Articles\* Articles\* /Y
copy Material.Blazor.MD3\Articles\Images\* Articles\Images\* /Y
copy Material.Blazor.MD3\docfxMD3.json docfx.json
copy Material.Blazor.MD3\indexMD3.md index.md
copy Material.Blazor.MD3\tocMD3.yml toc.yml
dotnet build Material.Blazor.MD3/Material.Blazor.MD3.csproj --configuration Server
docfx docfx.json --serve
rd Articles /s /q
del docfx.json
del index.md
del toc.yml
