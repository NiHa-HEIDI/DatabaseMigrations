using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524032831)]
    public class AddMullKalenderStreetsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_streets;
                 CREATE TABLE mullkalender_streets(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255) NOT NULL,
                    cityId int NOT NULL,
                    FOREIGN KEY (cityId) REFERENCES mullkalender_cities(id) ON DELETE CASCADE
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_streets;";

            Execute.Sql(sql);
        }
    }
}
