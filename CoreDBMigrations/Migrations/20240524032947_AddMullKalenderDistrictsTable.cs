using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524032947)]
    public class AddMullKalenderDistrictsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_districts;
                 CREATE TABLE mullkalender_districts(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255) NOT NULL,
                    UNIQUE (id, name)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_districts;";

            Execute.Sql(sql);
        }
    }
}
