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
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    zip varchar(32) NOT NULL,
                    district_id int NOT NULL,
                    pickupGroupId int NOT NULL,
                    FOREIGN KEY (district_id) REFERENCES mullkalender_districts(id),
                    FOREIGN KEY (pickupGroupId) REFERENCES mullkalender_pickup_groups(id)
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
