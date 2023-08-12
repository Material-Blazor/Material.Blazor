@echo on
rd /s /q SiteDocFx
md Articles
copy Material.Blazor\Articles\* Articles\* /Y
copy Material.Blazor\Articles\Images\* Articles\Images\* /Y
copy Material.Blazor\docfxMD2.json docfx.json /Y
copy Material.Blazor\indexMD2.md index.md /Y
copy Material.Blazor\tocMD2.yml toc.yml /Y
dotnet build Material.Blazor/Material.Blazor.csproj --configuration Server
docfx docfx.json --serve
rd Articles /s /q
del docfx.json
del index.md
del toc.yml
