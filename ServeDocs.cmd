@echo on
rmdir /s /q _site
.\DocFx\docfx.exe .\docfx.json --serve
