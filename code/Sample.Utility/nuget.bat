dotnet pack .\Sample.Utility.csproj -c Release -p:PackageVersion=0.0.6

dotnet nuget push bin\Release\Sample.Utility.0.0.6.nupkg --api-key oy2l3ctuynuefpyjqrxavcoiptyiljke7bkbm2lntocume -s https://api.nuget.org/v3/index.json