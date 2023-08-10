@echo on
for /d /r . %%d in (bin,obj,ClientBin,apiMD3,siteDocFxMD3) do @if exist "%%d" rd /s /q "%%d"
copy tocMD3.yml toc.yml /Y
docfx\docfx.exe docfxMD3.json --serve
