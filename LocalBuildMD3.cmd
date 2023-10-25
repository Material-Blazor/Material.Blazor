@echo on
dotnet pack Material.Blazor.MD3/Material.Blazor.MD3.csproj -p:Version="5.0.1" --configuration Server --output "c:\solutions\Local NuGet Packages" -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
dir "c:\solutions\Local NuGet Packages"
