# UniBanken

## How to run
Make sure that .NET 6 and Docker is installed.

To run the program on Windows, first open powershell, change directory to Server and define a connectionstring:
```powershell
$password = "yourpassword"
$connectionString = "Host=localhost;Username=pb;Password=$password;Database=pb;Port=5433;"
```

If on Mac or Linux, change to first 2 commands to:
```bash
password="yourpassword"
connectionString="Host=localhost;Username=pb;Password=$password;Database=pb;Port=5433;"
```

```powershell
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:PB" "$connectionString"
```

Then start the database:
```powershell
docker run --name some-postgres -p 5433:5432 -e POSTGRES_PASSWORD=$password -e POSTGRES_USER=pb -d postgres
```

Then run the project:
```powershell
dotnet run
```