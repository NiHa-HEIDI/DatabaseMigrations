using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(1)]
    public class AddCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS CITIES;
                 CREATE TABLE CITIES(
	                Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                Name varchar(255),
	                ConnectionString varchar(255)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS CITIES;";

            Execute.Sql(sql);
        }
    }
}
