@echo on
for /d /r . %%d in (bin,obj,ClientBin,Generated_Code,api,apiMD3,siteDocFx,siteDocFxMD3,node_modules,wip) do @if exist "%%d" rd /s /q "%%d"
rd .artifacts /s /q
pause
