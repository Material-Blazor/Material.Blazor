@echo on
for /d /r . %%d in (artifacts,bin,obj,ClientBin,Generated_Code,api,siteDocFx,node_modules,wip) do @if exist "%%d" rd /s /q "%%d"
pause
