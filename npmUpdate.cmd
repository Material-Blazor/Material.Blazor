@echo off
echo ...
echo ... Updating Material.Blazor
echo ...
cd material.blazor
call npm update -S
rem ***
cd ..\material.blazor.website
echo ...
echo ... Updating Material.Blazor.Website
echo ...
call npm update -S
rem ***
cd ..
echo ...
echo ... Updating docfx
echo ...
dotnet tool update -g docfx
rem ***
