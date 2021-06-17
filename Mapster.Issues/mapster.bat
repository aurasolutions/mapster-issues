del /s /q .\Contracts\*.*

dotnet tool update Mapster.Tool
dotnet tool restore

dotnet build
dotnet mapster model -a .\bin\debug\net5.0\Mapster.Issues.dll -o .\Contracts -n Mapster.Issues.Contracts -r -b Mapster.Issues.Domain