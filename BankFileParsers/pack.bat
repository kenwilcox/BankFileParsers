REM del *.nupkg
REM run the "Pack" option on the project in Visual Studio
REM I do not know why the command line stopped working
move bin\Release\BankFileParsers.0.2.0.nupkg .
nuget push BankFileParsers.0.2.0.nupkg -Source https://api.nuget.org/v3/index.json