# Database Migrations

We have created this project to maintain our database system. We create something called as a 'migration' which is any change done to the database which can also be reverted if needed. This helps in version control of our database. We are using fluent migration to 
achieve this which is written in .NET

## Setup
### Installation
First install these softwares in your local
- MySql 8.0
- DotNet 7.0

### Create two schemas on local

First we need to create two schemas on our local. Create two schemas with these name
- heidi_core
- heidi_city_0

```sql
CREATE SCHEMA heidi_core;
CREATE SCHEMA heidi_city_0;
```

Then, create a user with these credentials and **give all privilages** (can be done in administrator tab)
- username: devuser
- password: devpassword

### Execute migrations

Then run the migrations on your machine, just run the following commands where the DatabaseMigrations.sln file is present (This will be present in the **rootfile/DatabaseMigrations** )

```bash
dotnet build
dotnet run
```

### Create new database for a city
We then create a clone of the "heidi_city_0" database. Let's call it "heidi_city_1". 
Then, we add a entry into the city table with the connection string of database "heidi_city_1"

```sql
USE heidi_core;
INSERT INTO CITIES (id, name, connectionString) VALUES (1, "City 1", "server=localhost;user=devuser;password=devpassword;database=heidi_city_1");

```

## Additional Parameters
#### dbType
Run migrations project only on the particular  type ofdatabase
- all (default)
- core
- city

#### migrate
The direction the migrations are run
- up (default)
- down

#### targetVersion
An integer value that needs to be provided if we want to up or down migrate to

Example commands
```bash
dotnet run dbtype=city
dotnet run migrate=up
dotnet run migrate=down dbType=core targetVersion=6789987766289
```
