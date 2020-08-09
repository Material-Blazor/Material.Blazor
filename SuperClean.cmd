@echo on
for /d /r . %%d in (bin,obj,ClientBin,Generated_Code,api,_site,node_modules,wip) do @if exist "%%d" rd /s /q "%%d"
pause
