@echo on
for /d /r . %%d in (bin,obj,node_modules) do @if exist "%%d" rd /s /q "%%d"
pause
