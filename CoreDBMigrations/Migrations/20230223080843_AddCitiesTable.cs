using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230223080843)]
    public class AddCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS cities;
                 CREATE TABLE cities(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
	                connectionString varchar(255),
	                isAdminListings BOOLEAN
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS cities;";

            Execute.Sql(sql);
        }
    }
}
