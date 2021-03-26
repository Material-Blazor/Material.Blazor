@echo on
rmdir /s /q api
rmdir /s /q siteDocFx
.\DocFx\docfx.exe .\docfx.json --serve
