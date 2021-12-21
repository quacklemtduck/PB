# UniBanken

To run the program on windows, first open powershell, change directory to Server and add secrets:
```powershell
$password = "yourpassword"
$connectionString = "Host=localhost;Username=pb;Password=$password;Database=pb;Port=5433;"

dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:PB" "$connectionString"
```

Then start the database
```powershell
docker run --name some-postgres -p 5433:5432 -e POSTGRES_PASSWORD=$password -e POSTGRES_USER=pb -d postgres
```

Then run the project
```powershell
dotnet run
```