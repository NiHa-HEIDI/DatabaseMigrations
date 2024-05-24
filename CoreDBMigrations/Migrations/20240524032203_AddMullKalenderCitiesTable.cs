using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    // mullkalender_cities
    [Migration(20240524032203)]
    public class AddMullKalenderCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_cities;
                 CREATE TABLE mullkalender_cities(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255) NOT NULL
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_cities;";

            Execute.Sql(sql);
        }
    }
}
