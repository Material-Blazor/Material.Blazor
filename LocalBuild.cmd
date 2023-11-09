@echo off
set argVersion=%1
if "%1" == "" set argVersion=5.0.0-rc3
set argDestination=%2
if "%2" == "" set argDestination="c:\solutions\local nuget packages"

echo Version is %argVersion%
echo Destination is %argDestination%
echo ...
echo Beginning MD2 build
echo ...
dotnet pack Material.Blazor/Material.Blazor.csproj -p:Version=%argVersion% --configuration Server --output %argDestination% -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
echo ...
echo Beginning MD3 build
echo ...
dotnet pack Material.Blazor.MD3/Material.Blazor.MD3.csproj -p:Version=%argVersion% --configuration Server --output %argDestination% -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
echo ...
echo Build results
echo ...
dir %argDestination%
pause
