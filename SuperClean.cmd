@echo on
for /d /r . %%d in (bin,obj,ClientBin,Generated_Code,api,siteDocFx,siteDocFxMD3,node_modules,wip) do @if exist "%%d" rd /s /q "%%d"
rd .artifacts /s /q
pause
