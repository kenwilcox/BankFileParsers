REM del *.nupkg
nuget pack BankFileParsers.csproj -Prop Configuration=Release
nuget push BankFileParsers.0.1.6.nupkg -Source https://api.nuget.org/v3/index.json