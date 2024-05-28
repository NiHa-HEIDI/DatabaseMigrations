using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524052019)]
    public class AddMullKalenderPropertiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_properties;
                 CREATE TABLE mullkalender_properties(
                    id int NOT NULL PRIMARY KEY,
                    zip varchar(32) NOT NULL,
                    districtId int NOT NULL,
                    pickupGroupId int NOT NULL,
                    FOREIGN KEY (districtId) REFERENCES mullkalender_districts(id),
                    UNIQUE (id, zip, districtId, pickupGroupId)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_properties;";

            Execute.Sql(sql);
        }
    }
}
