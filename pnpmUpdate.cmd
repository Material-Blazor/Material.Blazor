@echo off
echo ...
echo ... Updating Material.Blazor
echo ...
cd material.blazor
call pnpm update
call pnpm outdated
rem ***
cd ..\material.blazor.website
echo ...
echo ... Updating Material.Blazor.Website
echo ...
call pnpm update
call pnpm outdated
rem ***
cd ..
rem echo ...
rem echo ... Updating docfx
rem echo ...
rem dotnet tool update -g docfx
rem ***
