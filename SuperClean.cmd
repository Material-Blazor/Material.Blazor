@echo on
for /d /r . %%d in (bin,obj,node_modules) do @if exist "%%d" rd /s /q "%%d"
rd .artifacts /s /q
rd siteDocFx /s /q
rd /siteDocFxMD3 /s /q
pause
