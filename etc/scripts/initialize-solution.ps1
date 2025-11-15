abp install-libs

cd src/ttshang.DbMigrator && dotnet run && cd -

cd src/ttshang.Blazor && dotnet dev-certs https -v -ep openiddict.pfx -p 4e0416e0-ff66-40da-b59f-345d5b2b5536




exit 0