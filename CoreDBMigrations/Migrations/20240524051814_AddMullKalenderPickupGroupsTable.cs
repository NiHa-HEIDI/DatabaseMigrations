using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524051814)]
    public class AddMullKalenderPickupGroupsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_pickup_groups;
                 CREATE TABLE mullkalender_pickup_groups(
                    pickupGroupId int,
                    wasteId int NOT NULL,
                    dateGroupId int NOT NULL,
                    FOREIGN KEY (wasteId) REFERENCES mullkalender_waste_types(id),
                    UNIQUE (pickupGroupId, wasteId, dateGroupId)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_pickup_groups;";

            Execute.Sql(sql);
        }
    }
}
