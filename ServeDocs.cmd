@echo on
for /d /r . %%d in (bin,obj,ClientBin,api,siteDocFx) do @if exist "%%d" rd /s /q "%%d"
copy tocMD2.yml toc.yml /Y
docfx\docfx.exe docfx.json --serve
