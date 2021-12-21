# UniBanken

To run the program, first start the database using docker:
```powershell
docker run --name some-postgres -p 5432:5432 -e POSTGRES_PASSWORD=mysecretpassword -e POSTGRES_USER=pb -d postgres
```
