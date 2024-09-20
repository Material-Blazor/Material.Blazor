@echo off
set argVersion=%1
if "%1" == "" set argVersion=5.0.104
set argDestination=%2
if "%2" == "" set argDestination="d:\local nuget packages\publish"

echo Version is %argVersion%
echo Destination is %argDestination%
echo ...
echo Beginning publish
echo ...
dotnet publish material.blazor.website.webassembly/material.blazor.website.webassembly.csproj -p:Version=%argVersion% --configuration WebAssembly  --artifacts-path .artifacts --sc --framework net8.0 --output %argDestination% --runtime browser-wasm
echo Build results
echo ...
dir %argDestination%
pause
