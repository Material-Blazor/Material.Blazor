@echo on
for /d /r . %%d in (bin,obj,node_modules) do @if exist "%%d" rd /s /q "%%d"
if exist .artifacts rd .artifacts /s /q
if exist siteDocFx rd siteDocFx /s /q
pause
