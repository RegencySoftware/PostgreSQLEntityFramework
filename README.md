# PostgreSQL .NET Entity Framework Example

The repo contains a .NET Core console app using Entity Framework to work with PostgresSQL.  This console app will truncation a table that holds Cryptocurrency symbols, reloads it, then runs a LINQ query. 

This application was developed using Database First and the entities were generated using [Npgsql Entity Framework Core Provider](https://www.npgsql.org/efcore/).

**Example**: dotnet ef dbcontext scaffold "Host=localhost;Database=sandbox;Username=sandbox_user;Password=sandboxuserpwd" Npgsql.EntityFrameworkCore.PostgreSQL

This example assumes you have PostgreSQL installed. 

**In order to run the application do the following:**

1. Run the Create Table statement under Resources\CreateTable.sql folder on your PostgresSQL instance.
2. Update the connection string under Framework\settings.json with a user id and password from your instance. 

**Project Contents:**

- Framework Folder: Setups up the service provider to inject services and property objects
- Services Folder:  A method that runs a LINQ query to pull crypto symbols
- Typical Model and Interface folders

**Sample Output:**

![](https://github.com/RegencySoftware/PostgreSQLEntityFramework/blob/main/PostgresSQLTest/Resources/ScreenShot.png?raw=true)