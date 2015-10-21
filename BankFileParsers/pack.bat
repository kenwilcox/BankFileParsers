del *.nupkg
nuget pack BankFileParsers.csproj -Prop Configuration=Release
nuget push *.nupkg