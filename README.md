# Database Migrations

We have created this project to maintain our database system. We create something called as a 'migration' which is any change done to the database which can also be reverted if needed. This helps in version control of our database. We are using fluent migration to 
achieve this which is written in .NET

## Setup
### Create two databases on local

First we need to create two databases on our local. create two bases on our loc 
- heidi_core
- heidi_city_0

### Execute migrations

Then run the migrations on your machine, just run the following commands where the DatabaseMigrations.sln file is present

```bash
dotnet build
dotnet run
```

### Create new database for a city
We duplicate the "heidi_city_0" database. Let's call it "heidi_city_1". Then, we add a entry into the city table with the connection string of database "heidi_city_1"

```sql
INSERT INTO CITIES VALUES (1, "City 1", "server=localhost;user=devuser;password=devpassword;database=heidi_city_1");
```

## Additional Parameters
#### dbType
Run migrations project only on the particular  type ofdatabase
- all (default)
- core
- city

#### migrate
The direction the migrations are run
- up(default)
- down

#### targetVersion
An integer value that needs to be provided if we want to up or down migrate to
