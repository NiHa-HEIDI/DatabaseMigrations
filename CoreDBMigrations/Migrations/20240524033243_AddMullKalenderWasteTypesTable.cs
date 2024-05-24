using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524033243)]
    public class AddMullKalenderWasteTypesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_waste_types;
                 CREATE TABLE mullkalender_waste_types(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255) NOT NULL
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_waste_types;";

            Execute.Sql(sql);
        }
    }
}
