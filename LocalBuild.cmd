@echo off
set argVersion=%1
if "%1" == "" set argVersion=5.0.104
set argDestination=%2
if "%2" == "" set argDestination="c:\solutions\local nuget packages"

echo Version is %argVersion%
echo Destination is %argDestination%
echo ...
echo Beginning build
echo ...
dotnet pack materia.blazor/material.blazor.csproj -p:Version=%argVersion% --configuration Server --output %argDestination% -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
echo ...
echo Build results
echo ...
dir %argDestination%
pause
